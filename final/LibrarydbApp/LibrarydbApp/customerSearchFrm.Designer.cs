
namespace LibrarydbApp
{
    partial class customerSearchFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new LibrarydbApp.LibraryDBDataSet();
            this.custSearchLbl = new System.Windows.Forms.Label();
            this.custSearchTextBox = new System.Windows.Forms.TextBox();
            this.custSearchViewBtn = new System.Windows.Forms.Button();
            this.tbl_customerTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_customerTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.customerPhoneNumDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerCityDataGridViewTextBoxColumn,
            this.customerStateDataGridViewTextBoxColumn,
            this.customerZipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblcustomerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 302);
            this.dataGridView1.TabIndex = 0;
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
            // custSearchLbl
            // 
            this.custSearchLbl.AutoSize = true;
            this.custSearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custSearchLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSearchLbl.Location = new System.Drawing.Point(115, 55);
            this.custSearchLbl.Name = "custSearchLbl";
            this.custSearchLbl.Size = new System.Drawing.Size(417, 32);
            this.custSearchLbl.TabIndex = 1;
            this.custSearchLbl.Text = "Search Customer By Last Name";
            // 
            // custSearchTextBox
            // 
            this.custSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custSearchTextBox.Location = new System.Drawing.Point(556, 52);
            this.custSearchTextBox.Name = "custSearchTextBox";
            this.custSearchTextBox.Size = new System.Drawing.Size(198, 39);
            this.custSearchTextBox.TabIndex = 2;
            // 
            // custSearchViewBtn
            // 
            this.custSearchViewBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.custSearchViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custSearchViewBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSearchViewBtn.Location = new System.Drawing.Point(836, 33);
            this.custSearchViewBtn.Name = "custSearchViewBtn";
            this.custSearchViewBtn.Size = new System.Drawing.Size(203, 74);
            this.custSearchViewBtn.TabIndex = 3;
            this.custSearchViewBtn.Text = "Submit";
            this.custSearchViewBtn.UseVisualStyleBackColor = false;
            this.custSearchViewBtn.Click += new System.EventHandler(this.custSearchViewBtn_Click);
            // 
            // tbl_customerTableAdapter
            // 
            this.tbl_customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // customerPhoneNumDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhoneNum";
            this.customerPhoneNumDataGridViewTextBoxColumn.HeaderText = "CustomerPhoneNum";
            this.customerPhoneNumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerPhoneNumDataGridViewTextBoxColumn.Name = "customerPhoneNumDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // customerCityDataGridViewTextBoxColumn
            // 
            this.customerCityDataGridViewTextBoxColumn.DataPropertyName = "CustomerCity";
            this.customerCityDataGridViewTextBoxColumn.HeaderText = "CustomerCity";
            this.customerCityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerCityDataGridViewTextBoxColumn.Name = "customerCityDataGridViewTextBoxColumn";
            // 
            // customerStateDataGridViewTextBoxColumn
            // 
            this.customerStateDataGridViewTextBoxColumn.DataPropertyName = "CustomerState";
            this.customerStateDataGridViewTextBoxColumn.HeaderText = "CustomerState";
            this.customerStateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerStateDataGridViewTextBoxColumn.Name = "customerStateDataGridViewTextBoxColumn";
            this.customerStateDataGridViewTextBoxColumn.Width = 60;
            // 
            // customerZipDataGridViewTextBoxColumn
            // 
            this.customerZipDataGridViewTextBoxColumn.DataPropertyName = "CustomerZip";
            this.customerZipDataGridViewTextBoxColumn.HeaderText = "CustomerZip";
            this.customerZipDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerZipDataGridViewTextBoxColumn.Name = "customerZipDataGridViewTextBoxColumn";
            this.customerZipDataGridViewTextBoxColumn.Width = 75;
            // 
            // customerSearchFrm
            // 
            this.AcceptButton = this.custSearchViewBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1211, 472);
            this.Controls.Add(this.custSearchViewBtn);
            this.Controls.Add(this.custSearchTextBox);
            this.Controls.Add(this.custSearchLbl);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customerSearchFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerSearchFrm";
            this.Load += new System.EventHandler(this.customerSearchFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label custSearchLbl;
        private System.Windows.Forms.TextBox custSearchTextBox;
        private System.Windows.Forms.Button custSearchViewBtn;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_customerTableAdapter tbl_customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerZipDataGridViewTextBoxColumn;
    }
}