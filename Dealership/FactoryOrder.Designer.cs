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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(202, 181);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(121, 21);
            this.cbxModel.TabIndex = 0;
            this.cbxModel.SelectedIndexChanged += new System.EventHandler(this.cbxModel_SelectedIndexChanged);
            // 
            // cbxTrim
            // 
            this.cbxTrim.FormattingEnabled = true;
            this.cbxTrim.Location = new System.Drawing.Point(202, 225);
            this.cbxTrim.Name = "cbxTrim";
            this.cbxTrim.Size = new System.Drawing.Size(121, 21);
            this.cbxTrim.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(59, 184);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(72, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Select Model:";
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(59, 228);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(63, 13);
            this.lblTrim.TabIndex = 3;
            this.lblTrim.Text = "Select Trim:";
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(189, 269);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(75, 23);
            this.btnAddInventory.TabIndex = 4;
            this.btnAddInventory.Text = "Order";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(26, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 102);
            this.listBox1.TabIndex = 5;
            // 
            // FactoryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 318);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddInventory);
            this.Controls.Add(this.lblTrim);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cbxTrim);
            this.Controls.Add(this.cbxModel);
            this.Name = "FactoryOrder";
            this.Text = "FactoryOrder";
            this.Load += new System.EventHandler(this.FactoryOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.ComboBox cbxTrim;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.ListBox listBox1;
    }
}