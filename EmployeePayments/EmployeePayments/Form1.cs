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
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            NameTxtBox.Text = "";
            HourlyRateTxtBox.Text = "";
            AmountofHoursTxtBox.Text = "";
            SalaryBonusTxtBox.Text = "";
            OvertimePaymentTxtBox.Text = "";
            OvertimeHoursTxtBox.Text = ""; ;
            SalaryWithoutBonusTxtBox.Text = "";
            TotalSalaryTxtBox.Text = "";
        }
    }
}
