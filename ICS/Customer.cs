using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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
            if (isValidate())
            {
                CustomerController customerController = new CustomerController();
                Customer customer = new Customer();
                customer.CustomerName = txtCustomerName.Text;
                customer.CustomerPhone = txtPhoneNo.Text;
                customer.CustomerAddress = txtCustomerName.Text;
                customer.CustomerEmail = txtEmail.Text;
                customer.Gender = ddlGender.Text;
                customerController.Create(customer);

                MessageBox.Show("Customer Registered Successfully");
                Utilities.ClearControl(gpCustomer);
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isValidate()
        {
            bool status = true;
            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                lblErrCustName.Text = "*";
                status = false;
            }
            if (string.IsNullOrEmpty(txtPhoneNo.Text))
            {
                lblErrPhone.Text = "*";
                status = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblErrEmail.Text = "*";
                status = false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                lblErrAddress.Text = "*";
                status = false;
            }
            if (ddlGender.SelectedIndex<0)
            {
                lblErrGender.Text = "*";
                status = false;
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtEmail.Text);
            if (!match.Success)
            {
                lblErrEmail.Text = "Invalid Email Format!";
                status = false;
            }
             
            return status;
        }
    }
}
