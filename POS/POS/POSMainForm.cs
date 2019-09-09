using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using ProductInventory;
using AddComputerDialogTest;

namespace POS
{
    public partial class POSMainForm : Form
    {
        List<Product> productInventory = new List<Product>();


        public POSMainForm()
        {
            InitializeComponent();
        }

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            Product p = null;

            // determine the type of product being added. switch based on that
            // calling the appropriate dialog to get the necessary info
            // create the object and add it to our inventory list and to the display
            // list

            if (productTypeCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Must select a product type first before adding.");
                return;
            }

            switch (productTypeCombobox.SelectedIndex)
            {
                case 0:  p = createComputerProduct();   break;
                case 1:  p = createChocolateProduct();  break;
                default:
                    MessageBox.Show("Unknown product selected");
                    return;
            }

            if (p != null)
            {
                productInventory.Add(p);
                productListListbox.Items.Add(p.ToFormattedString());
            }
        }

        private Product createComputerProduct()
        {
            // pop a AddComputerDialog. If return is cancel, give up
            // if return is dialog ok, try to create a computer object
            // return that reference

            AddComputerProductDialog acpd = new AddComputerProductDialog();

            DialogResult result;
            result = acpd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return null;
            }

            Product p = new Computer(acpd.ProductName,
                                     acpd.ProductID,
                                     acpd.ProductCost,
                                     acpd.InitialQuantity,
                                     acpd.RamSize,
                                     acpd.CPUSpeed);

            return p;
        }

        private Product createChocolateProduct()
        {
            MessageBox.Show("Under construction");

            return null;
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            int quantity;

            // verify that have a quantity to sell. If so, convert to a number

            if (quantityToSellTextbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Must first enter a quantity to sell");
                return;
            }

            if (!int.TryParse(quantityToSellTextbox.Text.Trim(), out quantity))
            {
                MessageBox.Show("Non numeric data in the quantity to sell");
                return;
            }

            // find the item that is selected to be sold, then run the sell behaviour
            // on that object

            int selectedItemIndex = productListListbox.SelectedIndex;
            if (selectedItemIndex == -1)
            {
                MessageBox.Show("Must select the product to be sold.");
                return;
            }

            try
            {
                productInventory[selectedItemIndex].Sell(quantity);
            }
            catch (ArgumentException excp)
            {
                MessageBox.Show($"Error: Cannot sell. {excp.Message}");
                return;
            }

            // the displaylist to show the new status of the product just sold

            productListListbox.Items[selectedItemIndex] = productInventory[selectedItemIndex].ToFormattedString();
        }

        private void SaveProductsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Select File to Save Product Inventory List";

            sfd.Filter = "Product Inventory Files|*.pil|Text Files|*.txt|All Files|*.*";
            sfd.FilterIndex = 1;

            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = sfd.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            // all inside a try/catch
            //
            // open a stream writer on 'productlist.txt' on the desktop
            // foreach product in my inventory, ,run the ToFileString() method
            // and write that to  file
            // close the file
            try
            {
                StreamWriter output = new StreamWriter(sfd.FileName);
                foreach (Product p in productInventory)
                {
                    output.WriteLine(productTypeString(p));
                    output.WriteLine(p.ToFileString());
                }
                output.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show($"File did not write. {excp.Message}");
                return;
            }

            MessageBox.Show($"Products have been save in {sfd.FileName}");
        }

        private string productTypeString(Product p)
        {
            if (p is Computer)
                return "COMPUTER";
            else if (p is Chocolate)
                return "CHOCOLATE";
            else
                return "UNKNOWN";
        }

        private void LoadProductsButton_Click(object sender, EventArgs e)
        {
            // let the user pick the file to open

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select a Product Inventory List";

            ofd.Filter      = "Product Inventory Files|*.pil|Text Files|*.txt|All Files|*.*";
            ofd.FilterIndex = 1;

            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = ofd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            // all inside a try/catch
            //
            // open a stream reader on 'productlist.txt' on the desktop
            // for each line in the file call the constructor that takes single string
            // and get a product object back. Add that object to my list and to the display list
            // close the file

            Product p = null;
            try
            {
                StreamReader input = new StreamReader(ofd.FileName);

                while (!input.EndOfStream)
                {
                    string productType = input.ReadLine();
                    switch (productType)
                    {
                        case "COMPUTER":
                            p = new Computer(input.ReadLine());
                            break;
                        case "CHOCOLATE":
                            p = new Chocolate(input.ReadLine());
                            break;
                        default:
                            MessageBox.Show("Unknown product in the file");
                            p = null;
                            break;
                    }

                    if (p != null)
                    {
                        productInventory.Add(p);
                        productListListbox.Items.Add(p.ToFormattedString());
                    }
                }

                input.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show($"File did not load. {excp.Message}");
                return;
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // make sure we have something selected

            int index = productListListbox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Must select an item before editing product.");
                return;
            }

            // create the edit dialog, have it prepopulate the contents of the field and then 
            // show the dialog

            Product p = productInventory[index];

            if (p is Computer)
            {
                EditComputerProduct(index);
            }
            else if (p is Chocolate)
            {
                EditChocolateProduct(index);
            }
            else
            {
                MessageBox.Show("Unknown product trying to be edited");
            }
        }

        private void EditChocolateProduct(int index)
        {
            MessageBox.Show("Editing chocolate not yet implemented");
        }
               
        private void EditComputerProduct(int index)
        {
            // create a dialog and configure for edit

            AddComputerProductDialog acpd = new AddComputerProductDialog();

            acpd.EditMode = true;

            Computer c = (Computer)productInventory[index];

            acpd.ProductName        = c.ProductName;
            acpd.ProductID          = c.ID;
            acpd.ProductCost        = c.Cost;
            acpd.InitialQuantity    = c.QuantityOnHand;
            acpd.RamSize            = c.RamSize;
            acpd.CPUSpeed           = c.CpuSpeed;

            // show the dialog and wait for an OK.

            DialogResult result = acpd.ShowDialog();

            // if answer was OK update the product inventory with the new values and update display
            if (result != DialogResult.OK)
                return;

            Product p = new Computer(acpd.ProductName,
                                     acpd.ProductID,
                                     acpd.ProductCost,
                                     acpd.InitialQuantity,
                                     acpd.RamSize,
                                     acpd.CPUSpeed);

            productInventory[index] = p;
            productListListbox.Items[index] = p.ToFormattedString();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check to see if we have something selected first; message if not

            int index = productListListbox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Must select an item before deleting.");
                return;
            }

            // issue confirmation dialog that item is really to be deleted

            Product p = productInventory[index];

            if (DialogResult.Yes != MessageBox.Show($"Are you sure you wish to delete {p.ProductName}?",
                                                    "Confirmation",
                                                    MessageBoxButtons.YesNo))
            {
                return;
            }

            // so really delete the item ; take it out of the prodcutInventory list
            // and the display list

            productInventory.RemoveAt(index);
            productListListbox.Items.RemoveAt(index);
        }
    }
}
