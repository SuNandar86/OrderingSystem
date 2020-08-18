using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICS.Controllers;
using ICS.Models;

namespace ICS.Views
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerController customerController = new CustomerController();
            Customer customer = new Customer();
            customer.CustomerName = txtCustomerName.Text;
            customer.CustomerPhone = txtPhoneNo.Text;
            customer.CustomerAddress = txtCustomerName.Text;
            customerController.Create(customer);
        }
    }
}
