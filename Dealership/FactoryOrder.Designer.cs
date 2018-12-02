namespace Dealership
{
    partial class FactoryOrder
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
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.cbxTrim = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblTrim = new System.Windows.Forms.Label();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.lbxInventory = new System.Windows.Forms.ListBox();
            this.gbxInventory = new System.Windows.Forms.GroupBox();
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxInventory.SuspendLayout();
            this.gbxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(139, 19);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(121, 21);
            this.cbxModel.TabIndex = 0;
            this.cbxModel.SelectedIndexChanged += new System.EventHandler(this.cbxModel_SelectedIndexChanged);
            // 
            // cbxTrim
            // 
            this.cbxTrim.FormattingEnabled = true;
            this.cbxTrim.Location = new System.Drawing.Point(139, 44);
            this.cbxTrim.Name = "cbxTrim";
            this.cbxTrim.Size = new System.Drawing.Size(121, 21);
            this.cbxTrim.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(35, 22);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(72, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Select Model:";
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(35, 47);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(63, 13);
            this.lblTrim.TabIndex = 3;
            this.lblTrim.Text = "Select Trim:";
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(185, 71);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(75, 23);
            this.btnAddInventory.TabIndex = 4;
            this.btnAddInventory.Text = "Order";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // lbxInventory
            // 
            this.lbxInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxInventory.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInventory.FormattingEnabled = true;
            this.lbxInventory.ItemHeight = 14;
            this.lbxInventory.Location = new System.Drawing.Point(6, 19);
            this.lbxInventory.Name = "lbxInventory";
            this.lbxInventory.Size = new System.Drawing.Size(275, 116);
            this.lbxInventory.TabIndex = 5;
            // 
            // gbxInventory
            // 
            this.gbxInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInventory.Controls.Add(this.lbxInventory);
            this.gbxInventory.Location = new System.Drawing.Point(12, 12);
            this.gbxInventory.Name = "gbxInventory";
            this.gbxInventory.Size = new System.Drawing.Size(292, 145);
            this.gbxInventory.TabIndex = 6;
            this.gbxInventory.TabStop = false;
            this.gbxInventory.Text = "Inventory";
            // 
            // gbxOrder
            // 
            this.gbxOrder.Controls.Add(this.cbxModel);
            this.gbxOrder.Controls.Add(this.cbxTrim);
            this.gbxOrder.Controls.Add(this.btnAddInventory);
            this.gbxOrder.Controls.Add(this.lblTrim);
            this.gbxOrder.Controls.Add(this.lblModel);
            this.gbxOrder.Location = new System.Drawing.Point(12, 164);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Size = new System.Drawing.Size(292, 100);
            this.gbxOrder.TabIndex = 7;
            this.gbxOrder.TabStop = false;
            this.gbxOrder.Text = "Place Order";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(59, 281);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(174, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FactoryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 316);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.gbxOrder);
            this.Controls.Add(this.gbxInventory);
            this.Name = "FactoryOrder";
            this.Text = "FactoryOrder";
            this.Load += new System.EventHandler(this.FactoryOrder_Load);
            this.gbxInventory.ResumeLayout(false);
            this.gbxOrder.ResumeLayout(false);
            this.gbxOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.ComboBox cbxTrim;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.ListBox lbxInventory;
        private System.Windows.Forms.GroupBox gbxInventory;
        private System.Windows.Forms.GroupBox gbxOrder;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClose;
    }
}