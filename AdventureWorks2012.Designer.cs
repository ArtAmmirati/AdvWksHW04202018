namespace salesOrderIDLookUp
{
    partial class MasterForm
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.salesOrderIDTB = new System.Windows.Forms.TextBox();
            this.CustomerCB = new System.Windows.Forms.ComboBox();
            this.customerLB = new System.Windows.Forms.Label();
            this.salesOrderLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 84);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(532, 187);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // salesOrderIDTB
            // 
            this.salesOrderIDTB.Location = new System.Drawing.Point(331, 45);
            this.salesOrderIDTB.Name = "salesOrderIDTB";
            this.salesOrderIDTB.Size = new System.Drawing.Size(213, 20);
            this.salesOrderIDTB.TabIndex = 1;
            this.salesOrderIDTB.TextChanged += new System.EventHandler(this.salesOrderIDTB_TextChanged);
            // 
            // CustomerCB
            // 
            this.CustomerCB.FormattingEnabled = true;
            this.CustomerCB.Location = new System.Drawing.Point(12, 44);
            this.CustomerCB.Name = "CustomerCB";
            this.CustomerCB.Size = new System.Drawing.Size(213, 21);
            this.CustomerCB.TabIndex = 2;
            this.CustomerCB.SelectedIndexChanged += new System.EventHandler(this.CustomerCB_SelectedIndexChanged);
            // 
            // customerLB
            // 
            this.customerLB.AutoSize = true;
            this.customerLB.Location = new System.Drawing.Point(12, 25);
            this.customerLB.Name = "customerLB";
            this.customerLB.Size = new System.Drawing.Size(51, 13);
            this.customerLB.TabIndex = 3;
            this.customerLB.Text = "Customer";
            // 
            // salesOrderLB
            // 
            this.salesOrderLB.AutoSize = true;
            this.salesOrderLB.Location = new System.Drawing.Point(331, 25);
            this.salesOrderLB.Name = "salesOrderLB";
            this.salesOrderLB.Size = new System.Drawing.Size(76, 13);
            this.salesOrderLB.TabIndex = 4;
            this.salesOrderLB.Text = "Sales Order ID";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 283);
            this.Controls.Add(this.salesOrderLB);
            this.Controls.Add(this.customerLB);
            this.Controls.Add(this.CustomerCB);
            this.Controls.Add(this.salesOrderIDTB);
            this.Controls.Add(this.dataGrid);
            this.Name = "MasterForm";
            this.Text = "AdventerureWorks2012";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox salesOrderIDTB;
        private System.Windows.Forms.ComboBox CustomerCB;
        private System.Windows.Forms.Label customerLB;
        private System.Windows.Forms.Label salesOrderLB;
    }
}

