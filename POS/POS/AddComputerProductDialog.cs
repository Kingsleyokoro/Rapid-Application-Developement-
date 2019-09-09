using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddComputerDialogTest
{
    public partial class AddComputerProductDialog : Form
    {
        public bool         EditMode = false;
        public new string   ProductName;
        public long         ProductID;
        public decimal      ProductCost;
        public int          InitialQuantity;
        public int          RamSize;
        public float        CPUSpeed;

        private bool haveValidProductName     = false;
        private bool haveValidProductID       = false;
        private bool haveValidProductCost     = false;
        private bool haveValidInitialQuantity = false;
        private bool haveValidRamSize         = false;
        private bool haveValidCPUSpeed        = false;

        public AddComputerProductDialog()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string badFieldName = null;
            string adviceString = null;

            if (!haveValidProductName)
            {
                badFieldName = "Product Name";
                adviceString = "Must enter the name of the product.";
            }
            else if (!haveValidProductID)
            {
                badFieldName = "Product ID";
                adviceString = "Product ID must be numeric, atlease 6 digits but no more than 10.";
            }
            else if (!haveValidProductCost)
            {
                badFieldName = "Product Cost";
                adviceString = "Cost must be greater than zero.";
            }
            else if (!haveValidInitialQuantity)
            {
                badFieldName = "Initial Quantity";
                adviceString = "Initial Quantity must be a whole number greater than or equal to 0.";
            }
            else if (!haveValidRamSize)
            {
                badFieldName = "RAM Size";
                adviceString = "RAM Size must be a whole number greater than 0.";
            }
            else if (!haveValidCPUSpeed)
            {
                badFieldName = "CPU Speed";
                adviceString = "CPU Speed must a numeric value greater than 0.";
            }

            if (badFieldName != null)
            {
                MessageBox.Show($"Invalid {badFieldName}.\n{adviceString}", "Data Entry Error");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void ProductNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (productNameTextbox.Text.Trim().Length == 0)
            {
                haveValidProductName = false;
            }
            else
            {
                haveValidProductName = true;
                ProductName = productNameTextbox.Text.Trim();
            }
        }

        private void ProductIDTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidProductID = false;

            if (long.TryParse(productIDTextbox.Text.Trim(), out ProductID))
            {
                if ((ProductID >= 100000) && (ProductID <= 9999999999L))
                {
                    haveValidProductID = true;
                }
            }
        }

        private void ProductCostTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidProductCost = false;

            if (decimal.TryParse(productCostTextbox.Text.Trim(), out ProductCost))
            {             
                haveValidProductCost = true;
            }
        }

        private void InitialQuantityTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidInitialQuantity = false;

            if (int.TryParse(initialQuantityTextbox.Text.Trim(), out InitialQuantity))
            {
                haveValidInitialQuantity = true;
            }

        }

        private void RamSizeTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidRamSize = false;

            if (int.TryParse(ramSizeTextbox.Text.Trim(), out RamSize))
            {
                haveValidRamSize = true;
            }
        }

        private void CpuSpeedTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidCPUSpeed = false;

            if (float.TryParse(cpuSpeedTextbox.Text.Trim(), out CPUSpeed))
            {
                haveValidCPUSpeed = true;
            }
        }

        private void AddComputerProductDialog_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                productNameTextbox.Text     = ProductName;
                productIDTextbox.Text       = ProductID.ToString();
                productCostTextbox.Text     = ProductCost.ToString();
                initialQuantityTextbox.Text = InitialQuantity.ToString();
                ramSizeTextbox.Text         = RamSize.ToString();
                cpuSpeedTextbox.Text        = CPUSpeed.ToString();

                addButton.Text = "Update";
                this.Text      = "Update Product";
            }
        }
    }
}
