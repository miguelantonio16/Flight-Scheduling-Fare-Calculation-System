using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARCALA_MidtermExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayFare_Click(object sender, EventArgs e)
        {
            
            int numberOfPassengers = int.Parse(txtPassengers.Text);

            
            int fare = 0;
            if (rbtnSingapore.Checked) fare = 8000;
            else if (rbtnThailand.Checked) fare = 7500;
            else if (rbtnHongKong.Checked) fare = 9000;
            else if (rbtnMalaysia.Checked) fare = 7700;
            else if (rbtnSouthKorea.Checked) fare = 9500;

            
            if (rbtnBusiness.Checked)
            {
                fare = (int)(fare * 0.75); 
            }

            
            int totalFare = fare * numberOfPassengers;

            
            lblFareDetails.Text = $"Total Fare for {numberOfPassengers} passenger(s): {totalFare}.00\n" +
                                  $"Customer Details:\n" +
                                  $"Name: {txtFirstName.Text} {txtLastName.Text}\n" +
                                  $"Address: {txtAddress.Text}\n" +
                                  $"Date Booked: {txtDateBooked.Text}\n" +
                                  $"Contact Info: {txtContact.Text}\n" +
                                  $"Destination: {(rbtnSingapore.Checked ? "Singapore" : rbtnThailand.Checked ? "Thailand" : rbtnHongKong.Checked ? "Hong Kong" : rbtnMalaysia.Checked ? "Malaysia" : "South Korea")}";
        }
    }
}
