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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblChosenCustomer = new System.Windows.Forms.Label();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.lblCarSelection = new System.Windows.Forms.Label();
            this.lblSelectedInventory = new System.Windows.Forms.Label();
            this.lbxInventory = new System.Windows.Forms.ListBox();
            this.tabReview = new System.Windows.Forms.TabPage();
            this.lblSelectedInventory2 = new System.Windows.Forms.Label();
            this.lblChosenCustomer2 = new System.Windows.Forms.Label();
            this.btnSellIt = new System.Windows.Forms.Button();
            this.lblCarSelection2 = new System.Windows.Forms.Label();
            this.lblCustomerNameReview = new System.Windows.Forms.Label();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.lbxSales = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabReview.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabCustomer);
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Controls.Add(this.tabReview);
            this.tabControl1.Controls.Add(this.tabSales);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(382, 272);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(374, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.btnCustomer);
            this.tabCustomer.Controls.Add(this.lblCustomerName);
            this.tabCustomer.Controls.Add(this.lblChosenCustomer);
            this.tabCustomer.Controls.Add(this.tbxCustomerName);
            this.tabCustomer.Controls.Add(this.lblEnterName);
            this.tabCustomer.Controls.Add(this.lbxCustomers);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(374, 246);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(7, 206);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Enter";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(264, 92);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "label1";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChosenCustomer
            // 
            this.lblChosenCustomer.AutoSize = true;
            this.lblChosenCustomer.Location = new System.Drawing.Point(235, 38);
            this.lblChosenCustomer.Name = "lblChosenCustomer";
            this.lblChosenCustomer.Size = new System.Drawing.Size(90, 13);
            this.lblChosenCustomer.TabIndex = 3;
            this.lblChosenCustomer.Text = "Chosen Customer";
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Location = new System.Drawing.Point(7, 180);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(132, 20);
            this.tbxCustomerName.TabIndex = 2;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnterName.Location = new System.Drawing.Point(6, 164);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(135, 13);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter New Customer Name";
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
            this.tabInventory.Controls.Add(this.lblCarSelection);
            this.tabInventory.Controls.Add(this.lblSelectedInventory);
            this.tabInventory.Controls.Add(this.lbxInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(374, 246);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // lblCarSelection
            // 
            this.lblCarSelection.AutoSize = true;
            this.lblCarSelection.Location = new System.Drawing.Point(222, 213);
            this.lblCarSelection.Name = "lblCarSelection";
            this.lblCarSelection.Size = new System.Drawing.Size(35, 13);
            this.lblCarSelection.TabIndex = 2;
            this.lblCarSelection.Text = "label1";
            // 
            // lblSelectedInventory
            // 
            this.lblSelectedInventory.AutoSize = true;
            this.lblSelectedInventory.Location = new System.Drawing.Point(99, 213);
            this.lblSelectedInventory.Name = "lblSelectedInventory";
            this.lblSelectedInventory.Size = new System.Drawing.Size(96, 13);
            this.lblSelectedInventory.TabIndex = 1;
            this.lblSelectedInventory.Text = "Selected Inventory";
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
            this.lbxInventory.Size = new System.Drawing.Size(361, 186);
            this.lbxInventory.TabIndex = 0;
            this.lbxInventory.DoubleClick += new System.EventHandler(this.lbxInventory_DoubleClick);
            // 
            // tabReview
            // 
            this.tabReview.Controls.Add(this.lblSelectedInventory2);
            this.tabReview.Controls.Add(this.lblChosenCustomer2);
            this.tabReview.Controls.Add(this.btnSellIt);
            this.tabReview.Controls.Add(this.lblCarSelection2);
            this.tabReview.Controls.Add(this.lblCustomerNameReview);
            this.tabReview.Location = new System.Drawing.Point(4, 22);
            this.tabReview.Name = "tabReview";
            this.tabReview.Size = new System.Drawing.Size(374, 246);
            this.tabReview.TabIndex = 4;
            this.tabReview.Text = "Review";
            this.tabReview.UseVisualStyleBackColor = true;
            // 
            // lblSelectedInventory2
            // 
            this.lblSelectedInventory2.AutoSize = true;
            this.lblSelectedInventory2.Location = new System.Drawing.Point(74, 115);
            this.lblSelectedInventory2.Name = "lblSelectedInventory2";
            this.lblSelectedInventory2.Size = new System.Drawing.Size(26, 13);
            this.lblSelectedInventory2.TabIndex = 7;
            this.lblSelectedInventory2.Text = "Car:";
            // 
            // lblChosenCustomer2
            // 
            this.lblChosenCustomer2.AutoSize = true;
            this.lblChosenCustomer2.Location = new System.Drawing.Point(74, 76);
            this.lblChosenCustomer2.Name = "lblChosenCustomer2";
            this.lblChosenCustomer2.Size = new System.Drawing.Size(85, 13);
            this.lblChosenCustomer2.TabIndex = 6;
            this.lblChosenCustomer2.Text = "Customer Name:";
            // 
            // btnSellIt
            // 
            this.btnSellIt.Location = new System.Drawing.Point(134, 170);
            this.btnSellIt.Name = "btnSellIt";
            this.btnSellIt.Size = new System.Drawing.Size(75, 23);
            this.btnSellIt.TabIndex = 5;
            this.btnSellIt.Text = "Sell";
            this.btnSellIt.UseVisualStyleBackColor = true;
            this.btnSellIt.Click += new System.EventHandler(this.btnSellIt_Click);
            // 
            // lblCarSelection2
            // 
            this.lblCarSelection2.AutoSize = true;
            this.lblCarSelection2.Location = new System.Drawing.Point(207, 115);
            this.lblCarSelection2.Name = "lblCarSelection2";
            this.lblCarSelection2.Size = new System.Drawing.Size(35, 13);
            this.lblCarSelection2.TabIndex = 4;
            this.lblCarSelection2.Text = "label2";
            // 
            // lblCustomerNameReview
            // 
            this.lblCustomerNameReview.AutoSize = true;
            this.lblCustomerNameReview.Location = new System.Drawing.Point(207, 76);
            this.lblCustomerNameReview.Name = "lblCustomerNameReview";
            this.lblCustomerNameReview.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerNameReview.TabIndex = 3;
            this.lblCustomerNameReview.Text = "label1";
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
            // Dealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 297);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dealership";
            this.Text = "Toyota Dealer";
            this.Load += new System.EventHandler(this.Dealership_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.tabReview.ResumeLayout(false);
            this.tabReview.PerformLayout();
            this.tabSales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.ListBox lbxInventory;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.ListBox lbxSales;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblChosenCustomer;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.TabPage tabReview;
        private System.Windows.Forms.Label lblCarSelection2;
        private System.Windows.Forms.Label lblCustomerNameReview;
        private System.Windows.Forms.Button btnSellIt;
        private System.Windows.Forms.Label lblCarSelection;
        private System.Windows.Forms.Label lblSelectedInventory;
        private System.Windows.Forms.Label lblSelectedInventory2;
        private System.Windows.Forms.Label lblChosenCustomer2;
    }
}

