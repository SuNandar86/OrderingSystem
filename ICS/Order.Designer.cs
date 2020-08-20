namespace ICS.Views
{
    partial class frmOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpOrder = new System.Windows.Forms.GroupBox();
            this.lblErrQuantity = new System.Windows.Forms.Label();
            this.lblErrPayment = new System.Windows.Forms.Label();
            this.lblErrProductName = new System.Windows.Forms.Label();
            this.lblErrBrand = new System.Windows.Forms.Label();
            this.lblErrCatName = new System.Windows.Forms.Label();
            this.lblErrCustName = new System.Windows.Forms.Label();
            this.lblErrorCustomer = new System.Windows.Forms.Label();
            this.ddlBrand = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ddlPaymentType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.SuspendLayout();
            // 
            // gpOrder
            // 
            this.gpOrder.Controls.Add(this.lblErrQuantity);
            this.gpOrder.Controls.Add(this.lblErrPayment);
            this.gpOrder.Controls.Add(this.lblErrProductName);
            this.gpOrder.Controls.Add(this.lblErrBrand);
            this.gpOrder.Controls.Add(this.lblErrCatName);
            this.gpOrder.Controls.Add(this.lblErrCustName);
            this.gpOrder.Controls.Add(this.lblErrorCustomer);
            this.gpOrder.Controls.Add(this.ddlBrand);
            this.gpOrder.Controls.Add(this.label8);
            this.gpOrder.Controls.Add(this.ddlCategory);
            this.gpOrder.Controls.Add(this.label4);
            this.gpOrder.Controls.Add(this.txtPrice);
            this.gpOrder.Controls.Add(this.btnCancel);
            this.gpOrder.Controls.Add(this.ddlPaymentType);
            this.gpOrder.Controls.Add(this.label7);
            this.gpOrder.Controls.Add(this.button2);
            this.gpOrder.Controls.Add(this.txtAmount);
            this.gpOrder.Controls.Add(this.label6);
            this.gpOrder.Controls.Add(this.button1);
            this.gpOrder.Controls.Add(this.txtQty);
            this.gpOrder.Controls.Add(this.label5);
            this.gpOrder.Controls.Add(this.label3);
            this.gpOrder.Controls.Add(this.ddlProduct);
            this.gpOrder.Controls.Add(this.label2);
            this.gpOrder.Controls.Add(this.ddlCustomer);
            this.gpOrder.Controls.Add(this.label1);
            this.gpOrder.Location = new System.Drawing.Point(12, 12);
            this.gpOrder.Name = "gpOrder";
            this.gpOrder.Size = new System.Drawing.Size(468, 400);
            this.gpOrder.TabIndex = 0;
            this.gpOrder.TabStop = false;
            this.gpOrder.Text = "Place Order";
            // 
            // lblErrQuantity
            // 
            this.lblErrQuantity.AutoSize = true;
            this.lblErrQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblErrQuantity.Location = new System.Drawing.Point(243, 235);
            this.lblErrQuantity.Name = "lblErrQuantity";
            this.lblErrQuantity.Size = new System.Drawing.Size(0, 20);
            this.lblErrQuantity.TabIndex = 14;
            this.lblErrQuantity.UseMnemonic = false;
            // 
            // lblErrPayment
            // 
            this.lblErrPayment.AutoSize = true;
            this.lblErrPayment.ForeColor = System.Drawing.Color.Red;
            this.lblErrPayment.Location = new System.Drawing.Point(340, 305);
            this.lblErrPayment.Name = "lblErrPayment";
            this.lblErrPayment.Size = new System.Drawing.Size(0, 20);
            this.lblErrPayment.TabIndex = 13;
            // 
            // lblErrProductName
            // 
            this.lblErrProductName.AutoSize = true;
            this.lblErrProductName.Font = new System.Drawing.Font("Zawgyi-One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrProductName.ForeColor = System.Drawing.Color.Red;
            this.lblErrProductName.Location = new System.Drawing.Point(341, 151);
            this.lblErrProductName.Name = "lblErrProductName";
            this.lblErrProductName.Size = new System.Drawing.Size(0, 25);
            this.lblErrProductName.TabIndex = 12;
            this.lblErrProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblErrBrand
            // 
            this.lblErrBrand.AutoSize = true;
            this.lblErrBrand.Font = new System.Drawing.Font("Zawgyi-One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrBrand.ForeColor = System.Drawing.Color.Red;
            this.lblErrBrand.Location = new System.Drawing.Point(341, 111);
            this.lblErrBrand.Name = "lblErrBrand";
            this.lblErrBrand.Size = new System.Drawing.Size(0, 25);
            this.lblErrBrand.TabIndex = 12;
            this.lblErrBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblErrCatName
            // 
            this.lblErrCatName.AutoSize = true;
            this.lblErrCatName.Font = new System.Drawing.Font("Zawgyi-One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrCatName.ForeColor = System.Drawing.Color.Red;
            this.lblErrCatName.Location = new System.Drawing.Point(341, 67);
            this.lblErrCatName.Name = "lblErrCatName";
            this.lblErrCatName.Size = new System.Drawing.Size(0, 25);
            this.lblErrCatName.TabIndex = 12;
            this.lblErrCatName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblErrCustName
            // 
            this.lblErrCustName.AutoSize = true;
            this.lblErrCustName.Font = new System.Drawing.Font("Zawgyi-One", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrCustName.ForeColor = System.Drawing.Color.Red;
            this.lblErrCustName.Location = new System.Drawing.Point(341, 34);
            this.lblErrCustName.Name = "lblErrCustName";
            this.lblErrCustName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblErrCustName.Size = new System.Drawing.Size(0, 25);
            this.lblErrCustName.TabIndex = 12;
            this.lblErrCustName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblErrorCustomer
            // 
            this.lblErrorCustomer.AutoSize = true;
            this.lblErrorCustomer.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCustomer.Location = new System.Drawing.Point(63, -95);
            this.lblErrorCustomer.Name = "lblErrorCustomer";
            this.lblErrorCustomer.Size = new System.Drawing.Size(40, 20);
            this.lblErrorCustomer.TabIndex = 11;
            this.lblErrorCustomer.Text = "Errors";
            // 
            // ddlBrand
            // 
            this.ddlBrand.Enabled = false;
            this.ddlBrand.FormattingEnabled = true;
            this.ddlBrand.Location = new System.Drawing.Point(172, 108);
            this.ddlBrand.Name = "ddlBrand";
            this.ddlBrand.Size = new System.Drawing.Size(163, 28);
            this.ddlBrand.TabIndex = 10;
            this.ddlBrand.Tag = "3";
            this.ddlBrand.SelectedIndexChanged += new System.EventHandler(this.ddlBrand_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Brand";
            // 
            // ddlCategory
            // 
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(172, 67);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(163, 28);
            this.ddlCategory.TabIndex = 9;
            this.ddlCategory.Tag = "2";
            this.ddlCategory.SelectedIndexChanged += new System.EventHandler(this.ddlCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(170, 192);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(163, 27);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Tag = "5";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ddlPaymentType
            // 
            this.ddlPaymentType.AutoCompleteCustomSource.AddRange(new string[] {
            "Cash",
            "Credit Card"});
            this.ddlPaymentType.FormattingEnabled = true;
            this.ddlPaymentType.Items.AddRange(new object[] {
            "Select Payment",
            "Cash ",
            "Credit Card"});
            this.ddlPaymentType.Location = new System.Drawing.Point(170, 305);
            this.ddlPaymentType.Name = "ddlPaymentType";
            this.ddlPaymentType.Size = new System.Drawing.Size(163, 28);
            this.ddlPaymentType.TabIndex = 5;
            this.ddlPaymentType.Tag = "8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Payment ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Create New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(170, 271);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(163, 27);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Tag = "7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(170, 233);
            this.txtQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(67, 27);
            this.txtQty.TabIndex = 3;
            this.txtQty.Tag = "6";
            this.txtQty.ValueChanged += new System.EventHandler(this.txtQty_ValueChanged);
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // ddlProduct
            // 
            this.ddlProduct.Enabled = false;
            this.ddlProduct.FormattingEnabled = true;
            this.ddlProduct.Location = new System.Drawing.Point(172, 148);
            this.ddlProduct.Name = "ddlProduct";
            this.ddlProduct.Size = new System.Drawing.Size(163, 28);
            this.ddlProduct.TabIndex = 2;
            this.ddlProduct.Tag = "4";
            this.ddlProduct.SelectedIndexChanged += new System.EventHandler(this.ddlProducts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // ddlCustomer
            // 
            this.ddlCustomer.FormattingEnabled = true;
            this.ddlCustomer.Location = new System.Drawing.Point(172, 31);
            this.ddlCustomer.Name = "ddlCustomer";
            this.ddlCustomer.Size = new System.Drawing.Size(163, 28);
            this.ddlCustomer.TabIndex = 1;
            this.ddlCustomer.Tag = "1";
            this.ddlCustomer.Text = "Choose Customer";
            this.ddlCustomer.DropDown += new System.EventHandler(this.ddlCustomer_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // frmOrder
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 424);
            this.Controls.Add(this.gpOrder);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.gpOrder.ResumeLayout(false);
            this.gpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpOrder;
        private System.Windows.Forms.ComboBox ddlPaymentType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox ddlBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorCustomer;
        private System.Windows.Forms.Label lblErrCustName;
        private System.Windows.Forms.Label lblErrCatName;
        private System.Windows.Forms.Label lblErrProductName;
        private System.Windows.Forms.Label lblErrBrand;
        private System.Windows.Forms.Label lblErrPayment;
        private System.Windows.Forms.Label lblErrQuantity;
    }
}

