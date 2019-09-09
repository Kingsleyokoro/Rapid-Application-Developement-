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
using System.Reflection;
using CustomerData;




namespace CustomerData
{

    public partial class PowerBillingSystem : Form
    {
        List<Customer> CustomerList = new List<Customer>();// create a list object which is instance of the customer class
        List<string> customerNames = new List<string>();
        private bool haveValidInput = false; //boolean flag for input data validation
        private int ValidInput = 0;
        private const int BILL_LIMIT = 1000; //assign a constant variable to the bill limit of 1000kwh!
        private decimal totalResidentialCustomerCharge;//tthis varaible summarizes the total charge of all residential customers
        private decimal totalCommcercialCustomerCharge;//this varaible summarizes the total charge of all commercial customers
        private decimal totalIndustrialCustomerCharge;//this varaible summarizes the total charge of all industrial customers
        private decimal totalCharge;//this varaible summarizes the total charge of all industrial customers


        public PowerBillingSystem()
        {
            InitializeComponent();
        }

        private void CalculateBillbutton_Click(object sender, EventArgs e)
        {
            //this event perform all bill calculation using seperate methods for different customer type
            //string customerInput = (CustomerTypecomboBox1.Text);
            decimal kwhUsedPerCustomer = decimal.Parse(KwhTextBox1.Text.Trim()); //converting customer input text to double to perform calculations
            string customerName = customerNameTextBox1.Text.Trim();
            int customerAccountNum; 
            
            //this try catch block handles the exception created
            //if the user tries to calculate the bill without inserting valid account number
            try
            {
                 customerAccountNum = int.Parse(accountNumberTextBox.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show($"Invalid Account number, please insert your account number.");
                return;
            }
            //in this try catch block the calculate bill is performed
            //based on the selected item/index by the user
            //objects are created as instances of sub classes depending on the selection by the customer
            try
            {
                switch (CustomerTypecomboBox1.SelectedItem)
                {
                    case "Residential":
                        ResidentialCustomer rcust = new ResidentialCustomer(customerAccountNum, customerName, "R");
                        rcust.ChargeAmount = rcust.CalculateCharge(kwhUsedPerCustomer);
                        EstimatedBillLabel.Text = "Estimated Bill: " + rcust.ChargeAmount.ToString("C");
                        break;
                    case "Commercial":
                        CommercialCustomer cCustomer = new CommercialCustomer(customerAccountNum, customerName, "C");
                        cCustomer.ChargeAmount = cCustomer.CalculateCharge(kwhUsedPerCustomer);
                        EstimatedBillLabel.Text = "Estimated Bill: " + cCustomer.ChargeAmount.ToString("C");
                        break;
                    case "Industrial":
                        decimal offpeakKwhUsedPerCustomer = decimal.Parse(OffpeakKwhTextBox1.Text.Trim());
                        IndustrialCustomer indCustomer = new IndustrialCustomer(customerAccountNum, customerName, "I");
                        indCustomer.ChargeAmount = indCustomer.CalculateCharge(kwhUsedPerCustomer, offpeakKwhUsedPerCustomer);
                        EstimatedBillLabel.Text = "Estimated Bill: " + indCustomer.ChargeAmount.ToString("C");
                        break;
                    default:
                        MessageBox.Show("Something went wrong bill could not be estimated");
                        break;
                }
                //eraseTextField();

            }
            catch (ArgumentException excp)
            {
                MessageBox.Show($"Unable to create new customer invalid information. {excp.Message}");
                return;
            }
            catch (FormatException excp)
            {
                MessageBox.Show($"Non numeric data in a numeric field. {excp.Message}");
                return;
            }
        }


        //this event terminates the application on confirmation by the user
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //this.Close();

            DialogResult userAnswer;

            userAnswer = MessageBox.Show("Do you wish to close the bill Estimator",
                            "Bill Estimator",
                            MessageBoxButtons.OKCancel);
            switch (userAnswer)
            {
                case DialogResult.OK:
                    Application.Exit();
                    break;
                case DialogResult.Cancel:
                    break;
                    // default:

            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //this event handler resets the windows app when clicked
            //and prompts the user before resetting
            DialogResult userAnswer;

            userAnswer = MessageBox.Show("Do you wish to Reset ?",
                            "Bill Estimator",
                            MessageBoxButtons.YesNo);
            switch (userAnswer)
            {
                case DialogResult.Yes:
                    KwhTextBox1.Clear();
                    OffpeakKwhTextBox1.Clear();
                    CustomerTypecomboBox1.SelectedIndex = 0;
                    break;
                case DialogResult.No:
                    //do nothing
                    break;
                default:
                    KwhTextBox1.Clear();
                    CustomerTypecomboBox1.SelectedIndex = 0;
                    break;

            }
            eraseTextField();
        }
        //this method clears all input into the form
        private void eraseTextField()
        {
            haveValidInput = true;
            EstimatedBillLabel.Text = "Estimated Bill: ";
            KwhLabel.Text = "How many Kwh?";
            OffPeakKwhlabel.Visible = false;
            OffpeakKwhTextBox1.Visible = false;
            KwhTextBox1.Clear();
            OffpeakKwhTextBox1.Clear();
            accountNumberTextBox.Clear();
            customerNameTextBox1.Clear();
        }
        //this event handler changes the form when the customer toggles between different customer types
        //industrial users have peakhours and offpeak hours
        //when an idustrial customer type is selected the forms toggles and dispays differently 
        private void CustomerTypecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when the user selects the Industrial customer type some labels and Text boxes become visible
            switch (CustomerTypecomboBox1.Text)
            {
                case "Industrial":
                    KwhLabel.Text = "How many peak Kwh?";
                    OffPeakKwhlabel.Visible = true;
                    OffpeakKwhTextBox1.Visible = true;
                    break;
                default:
                    KwhLabel.Text = "How many Kwh?";
                    OffPeakKwhlabel.Visible = false;
                    OffpeakKwhTextBox1.Visible = false;
                    break;

            }
            KwhTextBox1.Clear();
            OffpeakKwhTextBox1.Clear();

        }

        private void KwhTextBox1_TextChanged(object sender, EventArgs e)
        {
            //this validation toggles the calculate bill button on and off 
            //if the user enters a non integer value the estimate button is not enabled
            inputValidator(KwhTextBox1.Text);
        }


        //this event handler performs validation when the user enter data in the textbox
        //if invalid data the calculate button is disabled
        private void OffpeakKwhTextBox1_TextChanged(object sender, EventArgs e)
        {
            inputValidator(OffpeakKwhTextBox1.Text);
        }

        private void PowerBillingSystem_Load(object sender, EventArgs e)
        {
            //open stream reader on "Customer txt" on load

            string pathLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(pathLocation, "Customer.txt");

            //this block of code checks if the "Customer.txt" exist
            //if the file does not exist a message box displays 
            //the program does'nt crash
            if (File.Exists(filePath))
            {
                try
                {
                    StreamReader output = new StreamReader(filePath);

                    while (!output.EndOfStream)
                    {
                        string lineFronline = output.ReadLine();
                        Customer c = new Customer(lineFronline);
                        customerListListBox.Items.Add(c.ToFormattedString());


                        //add customer names to this list
                        customerNames.Add(c.CustomerName);

                        //the following of code calculates the summary statistics
                        switch (c.CustomerType)
                        {
                            case "R":
                                totalResidentialCustomerCharge += c.ChargeAmount;
                                break;
                            case "C":
                                totalCommcercialCustomerCharge += c.ChargeAmount;
                                break;
                            case "I":
                                totalIndustrialCustomerCharge += c.ChargeAmount;
                                break;
                            default:
                                return;
                        }
                        calculateStatistics();
                    }
                    output.Close(); //after loading the file , close it
                }catch(Exception excp)
                {
                    MessageBox.Show($"File failed to load {excp.Message}");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Customer.txt does not exist in the bin/Debug folder");
                return;
            }


            //on loading the form application residential customer type is set as default
            //Focus is set to user input text box
            CustomerTypecomboBox1.SelectedIndex = 0;
            KwhTextBox1.Select();
        }
        //this event adds the customer details into the list box
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            decimal kwhUsedPerCustomer = decimal.Parse(KwhTextBox1.Text.Trim()); //converting customer input text to double to perform calculations
            string customerName = customerNameTextBox1.Text.Trim();
            int customerAccountNum;

            //this try catch block handles the exception created
            //if the user tries to calculate the bill without inserting valid account number
            try
            {
                customerAccountNum = int.Parse(accountNumberTextBox.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show($"Invalid Account number, please insert your account number.");
                return;
            }


            Customer c = null;
            //Based the on user's selection in the combo box
            // a new customer object is created
            try
            {
                if (CustomerTypecomboBox1.SelectedIndex == 0)
                {
                    c = new ResidentialCustomer(customerAccountNum, customerName, "R");
                    c.ChargeAmount = c.CalculateCharge(kwhUsedPerCustomer);
                }
                else if (CustomerTypecomboBox1.SelectedIndex == 1)
                {
                    c = new CommercialCustomer(customerAccountNum, customerName, "C");
                    c.ChargeAmount = c.CalculateCharge(kwhUsedPerCustomer);
                }
                else
                {
                    decimal offpeakKwhUsedPerCustomer = decimal.Parse(OffpeakKwhTextBox1.Text.Trim());
                    c = new IndustrialCustomer(customerAccountNum, customerName, "I");
                    c.ChargeAmount = c.CalculateCharge(kwhUsedPerCustomer, offpeakKwhUsedPerCustomer);
                }
            }
            catch (ArgumentException excp)
            {
                MessageBox.Show($"Unable to create new customer, invalid information. {excp.Message}");
                return;
            }
            catch (FormatException excp)
            {
                MessageBox.Show($"Non numeric data in a numeric field. {excp.Message}");
                return;
            }
            //if a customer object is created successfully 
            // add the object to a customer list above and display in the list box

            if (c != null)
            {
                CustomerList.Add(c);
                customerListListBox.Items.Add(c.ToFormattedString());
            }

            //writing the customer data unto customer.txt!
            try
            {
                string pathLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string fileLocation = Path.Combine(pathLocation, "Customer.txt");

                StreamWriter output = new StreamWriter(fileLocation, true);
                foreach (Customer customer in CustomerList)
                {
                    output.WriteLine(customer.ToFileString());
                }
                output.Close();

            }
            catch (Exception excp)
            {
                MessageBox.Show($"File did not write. {excp.Message}");
                return;
            }
            MessageBox.Show("Customer data has been save succesfully in customer.txt");

        }
        //this method calculates the customer statistics summary!
        private void calculateStatistics()
        {
            totalCustomersLabel.Text = $"Total Customers: {customerNames.Count}";
            totalCharge = totalResidentialCustomerCharge + totalIndustrialCustomerCharge + totalCommcercialCustomerCharge;
            totalChargeLabel.Text = $"Total Charge: {totalCharge:C2}";
            TotalResidentialCustomerLabel.Text = $"Total Residential Customers Charge: {totalResidentialCustomerCharge:C2}";
            totalCommercialCustomersLabel.Text = $"Total Commercial Customers Charge: {totalCommcercialCustomerCharge:C2}";
            totalIndustrialCustomersLabel.Text = $"Total Industrial Customers Charge: {totalIndustrialCustomerCharge:C2}";
        }
        //this method performs data validation using try parse
        //if the user enters a non postive integer the calculate button is disable
        //and displays a message prompting the user to enter a valid input
        private void inputValidator(string kwhinputbyUser)
        {
            if (int.TryParse(kwhinputbyUser, out ValidInput) && ValidInput >= 0)
            {
                haveValidInput = true;
                CalculateBillbutton.Enabled = true;
            }
            else
            {
                haveValidInput = false;
                CalculateBillbutton.Enabled = false;
            }

            if (!haveValidInput)
            {
                EstimatedBillLabel.Text = "Please enter valid hours!";
            }
            else
            {
                EstimatedBillLabel.Text = "Estimated Bill: ";
            }
        }
        //this method checks the list customer names for repeating customers
        private bool isPresentInList(string name)
        {
            return (customerNames.Contains(name)) ? true : false;
        }
        
    }
}
