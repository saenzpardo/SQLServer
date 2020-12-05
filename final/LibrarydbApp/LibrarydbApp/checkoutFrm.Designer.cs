
namespace LibrarydbApp
{
    partial class checkoutFrm
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
            this.components = new System.ComponentModel.Container();
            this.checkoutCustLbl = new System.Windows.Forms.Label();
            this.productCheckoutLbl = new System.Windows.Forms.Label();
            this.checkoutDateLbl = new System.Windows.Forms.Label();
            this.checkoutCustIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new LibrarydbApp.LibraryDBDataSet();
            this.checkoutProductIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_customerTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_customerTableAdapter();
            this.tbl_productTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_productTableAdapter();
            this.currentDateLbl = new System.Windows.Forms.Label();
            this.dueDateLbl = new System.Windows.Forms.Label();
            this.showDueDateLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutCustLbl
            // 
            this.checkoutCustLbl.AutoSize = true;
            this.checkoutCustLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutCustLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkoutCustLbl.Location = new System.Drawing.Point(7, 25);
            this.checkoutCustLbl.Name = "checkoutCustLbl";
            this.checkoutCustLbl.Size = new System.Drawing.Size(171, 32);
            this.checkoutCustLbl.TabIndex = 0;
            this.checkoutCustLbl.Text = "Customer ID";
            // 
            // productCheckoutLbl
            // 
            this.productCheckoutLbl.AutoSize = true;
            this.productCheckoutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCheckoutLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productCheckoutLbl.Location = new System.Drawing.Point(7, 79);
            this.productCheckoutLbl.Name = "productCheckoutLbl";
            this.productCheckoutLbl.Size = new System.Drawing.Size(147, 32);
            this.productCheckoutLbl.TabIndex = 1;
            this.productCheckoutLbl.Text = "Product ID";
            // 
            // checkoutDateLbl
            // 
            this.checkoutDateLbl.AutoSize = true;
            this.checkoutDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkoutDateLbl.Location = new System.Drawing.Point(7, 138);
            this.checkoutDateLbl.Name = "checkoutDateLbl";
            this.checkoutDateLbl.Size = new System.Drawing.Size(180, 32);
            this.checkoutDateLbl.TabIndex = 2;
            this.checkoutDateLbl.Text = "Today\'s Date";
            this.checkoutDateLbl.Click += new System.EventHandler(this.checkoutDateLbl_Click);
            // 
            // checkoutCustIDComboBox
            // 
            this.checkoutCustIDComboBox.DataSource = this.tblcustomerBindingSource;
            this.checkoutCustIDComboBox.DisplayMember = "CustomerID";
            this.checkoutCustIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutCustIDComboBox.FormattingEnabled = true;
            this.checkoutCustIDComboBox.Location = new System.Drawing.Point(202, 25);
            this.checkoutCustIDComboBox.Name = "checkoutCustIDComboBox";
            this.checkoutCustIDComboBox.Size = new System.Drawing.Size(398, 40);
            this.checkoutCustIDComboBox.TabIndex = 3;
            this.checkoutCustIDComboBox.ValueMember = "CustomerID";
            // 
            // tblcustomerBindingSource
            // 
            this.tblcustomerBindingSource.DataMember = "tbl_customer";
            this.tblcustomerBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkoutProductIDComboBox
            // 
            this.checkoutProductIDComboBox.DataSource = this.tblproductBindingSource;
            this.checkoutProductIDComboBox.DisplayMember = "ProductName";
            this.checkoutProductIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutProductIDComboBox.FormattingEnabled = true;
            this.checkoutProductIDComboBox.Location = new System.Drawing.Point(202, 79);
            this.checkoutProductIDComboBox.Name = "checkoutProductIDComboBox";
            this.checkoutProductIDComboBox.Size = new System.Drawing.Size(398, 40);
            this.checkoutProductIDComboBox.TabIndex = 4;
            this.checkoutProductIDComboBox.ValueMember = "ProductID";
            // 
            // tblproductBindingSource
            // 
            this.tblproductBindingSource.DataMember = "tbl_product";
            this.tblproductBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(168, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 72);
            this.button1.TabIndex = 5;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_customerTableAdapter
            // 
            this.tbl_customerTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_productTableAdapter
            // 
            this.tbl_productTableAdapter.ClearBeforeFill = true;
            // 
            // currentDateLbl
            // 
            this.currentDateLbl.AutoSize = true;
            this.currentDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentDateLbl.Location = new System.Drawing.Point(205, 138);
            this.currentDateLbl.Name = "currentDateLbl";
            this.currentDateLbl.Size = new System.Drawing.Size(0, 32);
            this.currentDateLbl.TabIndex = 6;
            // 
            // dueDateLbl
            // 
            this.dueDateLbl.AutoSize = true;
            this.dueDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dueDateLbl.Location = new System.Drawing.Point(7, 185);
            this.dueDateLbl.Name = "dueDateLbl";
            this.dueDateLbl.Size = new System.Drawing.Size(134, 32);
            this.dueDateLbl.TabIndex = 7;
            this.dueDateLbl.Text = "Due Date";
            this.dueDateLbl.Click += new System.EventHandler(this.dueDateLbl_Click);
            // 
            // showDueDateLbl
            // 
            this.showDueDateLbl.AutoSize = true;
            this.showDueDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDueDateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showDueDateLbl.Location = new System.Drawing.Point(205, 185);
            this.showDueDateLbl.Name = "showDueDateLbl";
            this.showDueDateLbl.Size = new System.Drawing.Size(0, 32);
            this.showDueDateLbl.TabIndex = 8;
            // 
            // checkoutFrm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(656, 317);
            this.Controls.Add(this.showDueDateLbl);
            this.Controls.Add(this.dueDateLbl);
            this.Controls.Add(this.currentDateLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkoutProductIDComboBox);
            this.Controls.Add(this.checkoutCustIDComboBox);
            this.Controls.Add(this.checkoutDateLbl);
            this.Controls.Add(this.productCheckoutLbl);
            this.Controls.Add(this.checkoutCustLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "checkoutFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkoutFrm";
            this.Load += new System.EventHandler(this.checkoutFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkoutCustLbl;
        private System.Windows.Forms.Label productCheckoutLbl;
        private System.Windows.Forms.Label checkoutDateLbl;
        private System.Windows.Forms.ComboBox checkoutCustIDComboBox;
        private System.Windows.Forms.ComboBox checkoutProductIDComboBox;
        private System.Windows.Forms.Button button1;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_customerTableAdapter tbl_customerTableAdapter;
        private System.Windows.Forms.BindingSource tblproductBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_productTableAdapter tbl_productTableAdapter;
        private System.Windows.Forms.Label currentDateLbl;
        private System.Windows.Forms.Label dueDateLbl;
        private System.Windows.Forms.Label showDueDateLbl;
    }
}