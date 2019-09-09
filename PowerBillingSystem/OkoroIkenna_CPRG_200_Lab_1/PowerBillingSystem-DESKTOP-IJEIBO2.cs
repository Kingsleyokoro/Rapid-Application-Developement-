using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkoroIkenna_CPRG_200_Lab_1
{
    public partial class PowerBillingSystem : Form

    {
        private bool haveValidInput = false;
        private int ValidInput = 0;
        
        public PowerBillingSystem()
        {
            InitializeComponent();
          
        }

        private void CalculateBillbutton_Click(object sender, EventArgs e)
        {
            
            string customerInput = (CustomerTypecomboBox1.Text);
            double kwhUsedPerCustomer = double.Parse(KwhTextBox1.Text);
            double offpeakKwhUsedPerCustomer = double.Parse(OffpeakKwhTextBox1.Text);
            double EstimatedBill;
             
            switch(CustomerTypecomboBox1.SelectedItem)
            {
                case "Residential":
                    EstimatedBill = calculateResidentialBill(kwhUsedPerCustomer);
                    EstimatedBillLabel.Text = "Estimated Bill: " + EstimatedBill.ToString("C");
                    break;
                case "Commercial":
                    EstimatedBill = calculateCommercialBill(kwhUsedPerCustomer);
                    EstimatedBillLabel.Text = "Estimated Bill: " + EstimatedBill.ToString("C");
                    break;
                //case "Industrial":
                //    if
                    
                //    break;

                default:
                    EstimatedBillLabel.Text = "Oops something went wrong";
                    break;



            }

        }

        private double calculateResidentialBill(double kwhused)
        {
            double residentFlatRate = 6;
            double kwhDefault = 0.052;

            double totalBill = residentFlatRate + (kwhDefault * kwhused);
            return totalBill;
        }

        //this method performs totalBill calculation for commercial customer type
        private double calculateCommercialBill(double kwhused)
        {
            double commercialFlatRate = 60;
            double kwhDefault = 0.045;
            double totalBill;

            if (kwhused <= 1000)
            {
                totalBill = commercialFlatRate;
                
            }
            else 
            {
                totalBill = commercialFlatRate + (kwhDefault * kwhused);
            }
            return totalBill;
        }

        private double calculateIndustrialBillOffPeakHours(double kwhused)
        {
            double commercialFlatRate = 40;
            double kwhDefault = 0.028;
            double totalBill;

            if (kwhused <= 1000)
            {
                totalBill = commercialFlatRate;

            }
            else
            {
                totalBill = commercialFlatRate + (kwhDefault * kwhused);
            }
            return totalBill;
        }

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
                    //;
                    break;
                    // default:

            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            

            DialogResult userAnswer;

            userAnswer = MessageBox.Show("Do you wish to Reset ?",
                            "Bill Estimator",
                            MessageBoxButtons.YesNo);
            switch (userAnswer)
            {
                case DialogResult.Yes:
                    KwhTextBox1.Text = "";
                    CustomerTypecomboBox1.Text = "";
                    
                    break;
                case DialogResult.No:
                    //do nothing
                    break;
                //default:
                    //haveValidInput = true;
                    //break;

            }
            haveValidInput = true;
            EstimatedBillLabel.Text = "Estimated Bill: ";
            KwhLabel.Text = "How many Kwh?";
            OffPeakKwhlabel.Visible = false;
            OffpeakKwhTextBox1.Visible = false;
        }

        private void CustomerTypecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            
        }

        private void KwhTextBox1_TextChanged(object sender, EventArgs e)
        {
            //this validation toggles the calculate bill button on and off 
            //if the user enters a non integer value the estimate button isturned off
            if (int.TryParse(KwhTextBox1.Text, out ValidInput) && ValidInput > 0)
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
       

        private void OffpeakKwhTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(OffpeakKwhTextBox1.Text, out ValidInput) && ValidInput > 0)
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

        private void PowerBillingSystem_Load(object sender, EventArgs e)
        {
            CustomerTypecomboBox1.SelectedItem = CustomerTypecomboBox1.Items.IndexOf(0);
        }
    }
}
