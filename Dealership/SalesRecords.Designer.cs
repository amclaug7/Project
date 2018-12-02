namespace Dealership
{
    partial class SalesRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.gbxCustomers = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCarSelection = new System.Windows.Forms.Label();
            this.lbxInventory = new System.Windows.Forms.ListBox();
            this.tabReview = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblChosenCustomer2 = new System.Windows.Forms.Label();
            this.lblSelectedInventory2 = new System.Windows.Forms.Label();
            this.lblCarSelection2 = new System.Windows.Forms.Label();
            this.lblCustomerNameReview = new System.Windows.Forms.Label();
            this.btnSellIt = new System.Windows.Forms.Button();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.lbxSales = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.gbxCustomers.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabReview.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabCustomer);
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Controls.Add(this.tabReview);
            this.tabControl1.Controls.Add(this.tabSales);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(382, 272);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.gbxCustomers);
            this.tabCustomer.Controls.Add(this.btnCustomer);
            this.tabCustomer.Controls.Add(this.tbxCustomerName);
            this.tabCustomer.Controls.Add(this.lblEnterName);
            this.tabCustomer.Controls.Add(this.lbxCustomers);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(374, 246);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "Customers";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // gbxCustomers
            // 
            this.gbxCustomers.Controls.Add(this.lblCustomerName);
            this.gbxCustomers.Location = new System.Drawing.Point(193, 7);
            this.gbxCustomers.Name = "gbxCustomers";
            this.gbxCustomers.Size = new System.Drawing.Size(175, 144);
            this.gbxCustomers.TabIndex = 6;
            this.gbxCustomers.TabStop = false;
            this.gbxCustomers.Text = "Selected Customer";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerName.Location = new System.Drawing.Point(26, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(143, 141);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(236, 197);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Enter";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Location = new System.Drawing.Point(10, 199);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(177, 20);
            this.tbxCustomerName.TabIndex = 2;
            // 
            // lblEnterName
            // 
            this.lblEnterName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnterName.Location = new System.Drawing.Point(10, 169);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(177, 16);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter New Customer Name";
            this.lblEnterName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.ItemHeight = 14;
            this.lbxCustomers.Location = new System.Drawing.Point(7, 7);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(180, 144);
            this.lbxCustomers.TabIndex = 0;
            this.lbxCustomers.DoubleClick += new System.EventHandler(this.lbxCustomers_DoubleClick);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.groupBox1);
            this.tabInventory.Controls.Add(this.lbxInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(374, 246);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCarSelection);
            this.groupBox1.Location = new System.Drawing.Point(7, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Inventory";
            // 
            // lblCarSelection
            // 
            this.lblCarSelection.Location = new System.Drawing.Point(6, 16);
            this.lblCarSelection.Name = "lblCarSelection";
            this.lblCarSelection.Size = new System.Drawing.Size(349, 50);
            this.lblCarSelection.TabIndex = 2;
            this.lblCarSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxInventory
            // 
            this.lbxInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxInventory.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInventory.FormattingEnabled = true;
            this.lbxInventory.ItemHeight = 14;
            this.lbxInventory.Location = new System.Drawing.Point(7, 7);
            this.lbxInventory.Name = "lbxInventory";
            this.lbxInventory.Size = new System.Drawing.Size(361, 158);
            this.lbxInventory.TabIndex = 0;
            this.lbxInventory.DoubleClick += new System.EventHandler(this.lbxInventory_DoubleClick);
            // 
            // tabReview
            // 
            this.tabReview.Controls.Add(this.groupBox2);
            this.tabReview.Controls.Add(this.btnSellIt);
            this.tabReview.Location = new System.Drawing.Point(4, 22);
            this.tabReview.Name = "tabReview";
            this.tabReview.Size = new System.Drawing.Size(374, 246);
            this.tabReview.TabIndex = 4;
            this.tabReview.Text = "Review";
            this.tabReview.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblChosenCustomer2);
            this.groupBox2.Controls.Add(this.lblSelectedInventory2);
            this.groupBox2.Controls.Add(this.lblCarSelection2);
            this.groupBox2.Controls.Add(this.lblCustomerNameReview);
            this.groupBox2.Location = new System.Drawing.Point(19, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 105);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Review of Sale";
            // 
            // lblChosenCustomer2
            // 
            this.lblChosenCustomer2.Location = new System.Drawing.Point(6, 27);
            this.lblChosenCustomer2.Name = "lblChosenCustomer2";
            this.lblChosenCustomer2.Size = new System.Drawing.Size(97, 13);
            this.lblChosenCustomer2.TabIndex = 6;
            this.lblChosenCustomer2.Text = "Customer Name:";
            this.lblChosenCustomer2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSelectedInventory2
            // 
            this.lblSelectedInventory2.Location = new System.Drawing.Point(6, 64);
            this.lblSelectedInventory2.Name = "lblSelectedInventory2";
            this.lblSelectedInventory2.Size = new System.Drawing.Size(37, 13);
            this.lblSelectedInventory2.TabIndex = 7;
            this.lblSelectedInventory2.Text = "Car:";
            this.lblSelectedInventory2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCarSelection2
            // 
            this.lblCarSelection2.AutoSize = true;
            this.lblCarSelection2.Location = new System.Drawing.Point(128, 64);
            this.lblCarSelection2.Name = "lblCarSelection2";
            this.lblCarSelection2.Size = new System.Drawing.Size(0, 13);
            this.lblCarSelection2.TabIndex = 4;
            // 
            // lblCustomerNameReview
            // 
            this.lblCustomerNameReview.AutoSize = true;
            this.lblCustomerNameReview.Location = new System.Drawing.Point(128, 27);
            this.lblCustomerNameReview.Name = "lblCustomerNameReview";
            this.lblCustomerNameReview.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerNameReview.TabIndex = 3;
            // 
            // btnSellIt
            // 
            this.btnSellIt.Location = new System.Drawing.Point(139, 172);
            this.btnSellIt.Name = "btnSellIt";
            this.btnSellIt.Size = new System.Drawing.Size(67, 23);
            this.btnSellIt.TabIndex = 5;
            this.btnSellIt.Text = "Sell";
            this.btnSellIt.UseVisualStyleBackColor = true;
            this.btnSellIt.Click += new System.EventHandler(this.btnSellIt_Click);
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.lbxSales);
            this.tabSales.Location = new System.Drawing.Point(4, 22);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSales.Size = new System.Drawing.Size(374, 246);
            this.tabSales.TabIndex = 3;
            this.tabSales.Text = "Sales";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // lbxSales
            // 
            this.lbxSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxSales.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSales.FormattingEnabled = true;
            this.lbxSales.ItemHeight = 14;
            this.lbxSales.Location = new System.Drawing.Point(7, 7);
            this.lbxSales.Name = "lbxSales";
            this.lbxSales.Size = new System.Drawing.Size(361, 228);
            this.lbxSales.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClose);
            this.tabPage2.Controls.Add(this.btnLogOut);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(374, 246);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Exit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(141, 143);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(141, 79);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // SalesRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 297);
            this.Controls.Add(this.tabControl1);
            this.Name = "SalesRecords";
            this.Text = "Toyota Dealer";
            this.Load += new System.EventHandler(this.Dealership_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            this.gbxCustomers.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabReview.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSales.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.ListBox lbxInventory;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.ListBox lbxSales;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.TabPage tabReview;
        private System.Windows.Forms.Label lblCarSelection2;
        private System.Windows.Forms.Label lblCustomerNameReview;
        private System.Windows.Forms.Button btnSellIt;
        private System.Windows.Forms.Label lblCarSelection;
        private System.Windows.Forms.Label lblSelectedInventory2;
        private System.Windows.Forms.Label lblChosenCustomer2;
        private System.Windows.Forms.GroupBox gbxCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogOut;
    }
}

