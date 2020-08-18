using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICS.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           if( e.ClickedItem.Text == "Customer")
            {
                frmCustomer fcustomer = new frmCustomer();
                fcustomer.ShowDialog();
            }
            else
            {
                frmOrder forder = new frmOrder();
                forder.ShowDialog();
            }
                        
        }
    }
}
