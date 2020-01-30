using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayments
{
    public partial class Form1 : Form
    {
        const double EMPLOYEE_BONUS = 0.01;
        public Form1()
        {
            InitializeComponent();
        }
        /**
         * 1.- The exit buttton, exits the program 
        */
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        /**
         * 1.- The restart buttton clears all the data in the textbox's using two ways
         *     calling a function or one by one
        */
        private void RestartButton_Click(object sender, EventArgs e)
        {
            //NameTxtBox.Text = "";
            //HourlyRateTxtBox.Text = "";
            //AmountofHoursTxtBox.Text = "";
            //SalaryBonusTxtBox.Text = "";
            //OvertimePaymentTxtBox.Text = "";
            //OvertimeHoursTxtBox.Text = ""; ;
            //SalaryWithoutBonusTxtBox.Text = "";
            //TotalSalaryTxtBox.Text = "";
            CleartextBoxes1();
        }
        /**
         * 1.- Exception occurs in try block and handled in catch block
         * 2.- The value obtain in the HourlyRateTxtBox, and AmountofHoursTxtBox is assigned to
         *     two variables
         *     
        */
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //double hourlyRate = 0.0;
            //double amountOfHours = 0.0;

            try
            {
                double hourlyRate = double.Parse(HourlyRateTxtBox.Text);
                double amountOfHours = double.Parse(AmountofHoursTxtBox.Text);

            }
            catch
            {
                MessageBox.Show("Input Error");
                CleartextBoxes1();
            }
            
        }

        public void CleartextBoxes1()

        {

            foreach (Control Cleartext in this.Controls)

            {

                if (Cleartext is TextBox)

                {

                    ((TextBox)Cleartext).Text = string.Empty;

                }

            }

        }
    }
}
