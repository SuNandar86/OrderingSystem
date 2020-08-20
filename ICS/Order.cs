using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
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
        private void Order_Load(object sender, EventArgs e)
        {
            BindCustomer();
            BindCategory();
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)        {
            
            Invoice invoice = new Invoice();
            invoice.CustomerID =Convert.ToInt32(ddlCustomer.SelectedValue);
            invoice.ItemID = Convert.ToInt32(ddlProduct.SelectedValue);
            invoice.Quantity = Convert.ToInt32(txtQty.Text);
            invoice.Amount = Convert.ToInt32(txtAmount.Text);
            invoice.InvoiceDate = DateTime.Now;

            Payment payment = new Payment();
            payment.CustomerID= Convert.ToInt32(ddlCustomer.SelectedValue);
            payment.PaymentType = ddlPaymentType.Text;
            payment.Amount = Convert.ToInt32(txtAmount.Text);
            payment.PaymentDate = DateTime.Now;


            FacadeOrderController order = new FacadeOrderController();
            order.PlaceOrder(invoice,payment);

            MessageBox.Show("Order Placed Successfully");
            Utilities.ClearTextBoxes(gpOrder);
        }        
       
        private void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductController controller = new ProductController();
            Product product = controller.GetPrice(Convert.ToInt32(ddlProduct.SelectedValue));
            txtPrice.Text = product.Price.ToString();
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            decimal amount = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQty.Value);
            txtAmount.Text = amount.ToString();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer fcustomer = new frmCustomer();
            //this.Close();
            fcustomer.ShowDialog();
           
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindBrand(Convert.ToInt32(ddlCategory.SelectedValue));
        }

        private void ddlBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindProduct(Convert.ToInt32(ddlBrand.SelectedValue));
        }
        private void BindBrand(int category_id)
        {
            ddlBrand.Text = string.Empty;

            BrandController controller = new BrandController();
            BrandCollections collection = controller.GetCategoryList(category_id);
            ddlBrand.DisplayMember = "BrandName";
            ddlBrand.ValueMember = "BrandID";
            ddlBrand.DataSource = collection;
            ddlBrand.Enabled = true;
        }
        private void BindProduct(int brand_id)
        {
            ddlProduct.Text = string.Empty;

            ProductController controller = new ProductController();
            ProductCollections collection = controller.GetProductList(brand_id);
            ddlProduct.DisplayMember = "ProductName";
            ddlProduct.ValueMember = "ProductID";
            ddlProduct.DataSource = collection;           
            ddlProduct.Enabled = true;    
        }
        private void BindCustomer()
        {
            CustomerController controller = new CustomerController();
            CustomerCollections collection = controller.GetCustomerList();
            ddlCustomer.DisplayMember = "CustomerName";
            ddlCustomer.ValueMember = "CustomerID";
            ddlCustomer.DataSource = collection;
            ddlCustomer.SelectedIndex = 0;
        }
        public void BindCategory()
        {
            CategoryController controller = new CategoryController();
            CategoryCollections collection = controller.GetCategoryList(); 
            ddlCategory.DisplayMember = "CategoryName";
            ddlCategory.ValueMember = "CategoryID";
            ddlCategory.DataSource = collection;
            ddlCategory.SelectedIndex = 0;
        }

        private void ddlCustomer_DropDown(object sender, EventArgs e)
        {
            CustomerController controller = new CustomerController();
            CustomerCollections collection = controller.GetCustomerList();
            ddlCustomer.DisplayMember = "CustomerName";
            ddlCustomer.ValueMember = "CustomerID";
            ddlCustomer.DataSource = collection;          
            ddlCustomer.SelectedIndex = 0;           
        }
    }
}
