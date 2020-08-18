using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICS.Controllers;
using ICS.Models;

namespace ICS.Views
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }                

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            OrderController order = new OrderController();
            Invoice invoice = new Invoice();
            invoice.CustomerID =Convert.ToInt32(ddlCustomer.SelectedValue);
            invoice.ItemID = Convert.ToInt32(ddlProducts.SelectedValue);
            invoice.Quantity = Convert.ToInt32(lblPrice.Text);
            invoice.Amount = Convert.ToInt32(txtAmount.Text);

            Payment payment = new Payment();
            payment.CustomerID= Convert.ToInt32(ddlCustomer.SelectedValue);
            payment.PaymentType = ddlPaymentType.Text;
            payment.Amount = Convert.ToInt32(txtAmount.Text);
            payment.PaymentDate = DateTime.Now;
            order.PlaceOrder(invoice,payment);            
        }

        private void Order_Load(object sender, EventArgs e)
        {
            BindProduct();
            BindCustomer();
        }
        private void BindProduct()
        {
            ProductController controller = new ProductController();
            ProductCollections collection = controller.GetProductList();
            ddlProducts.DisplayMember = "ProductName";
            ddlProducts.ValueMember = "ProductID";
            ddlProducts.DataSource = collection;
            ddlProducts.SelectedIndex = -1;
        }
        private void BindCustomer()
        {
            CustomerController controller = new CustomerController();
            CustomerCollections collection = controller.GetCustomerList();
            ddlCustomer.DisplayMember = "CustomerName";
            ddlCustomer.ValueMember = "CustomerID";
            ddlCustomer.DataSource = collection;
            ddlCustomer.SelectedIndex = -1;
        }

        private void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductController controller = new ProductController();
            Product product = controller.GetPrice(Convert.ToInt32(ddlProducts.SelectedValue));
            lblPrice.Text = product.Price.ToString();
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
           decimal amount = Convert.ToInt32(lblPrice.Text) * Convert.ToInt32(txtQty.Value);
            txtAmount.Text = amount.ToString();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer fcustomer = new frmCustomer();
            fcustomer.ShowDialog();
            this.Close();
        }
    }
}
