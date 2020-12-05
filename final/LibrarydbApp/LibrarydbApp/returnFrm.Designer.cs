
namespace LibrarydbApp
{
    partial class returnFrm
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
            this.returnBtn = new System.Windows.Forms.Button();
            this.returnComboBoxLbl = new System.Windows.Forms.Label();
            this.returnComboBox = new System.Windows.Forms.ComboBox();
            this.tblborrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new LibrarydbApp.LibraryDBDataSet();
            this.tbl_borrowTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_borrowTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spDisplayBorrowedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet3 = new LibrarydbApp.LibraryDBDataSet3();
            this.spDisplayBorrowedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet2 = new LibrarydbApp.LibraryDBDataSet2();
            this.spDisplayBorrowedTableAdapter = new LibrarydbApp.LibraryDBDataSet2TableAdapters.spDisplayBorrowedTableAdapter();
            this.spDisplayBorrowedTableAdapter1 = new LibrarydbApp.LibraryDBDataSet3TableAdapters.spDisplayBorrowedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblborrowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDisplayBorrowedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDisplayBorrowedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnBtn.Location = new System.Drawing.Point(520, 34);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(185, 72);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // returnComboBoxLbl
            // 
            this.returnComboBoxLbl.AutoSize = true;
            this.returnComboBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnComboBoxLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnComboBoxLbl.Location = new System.Drawing.Point(32, 54);
            this.returnComboBoxLbl.Name = "returnComboBoxLbl";
            this.returnComboBoxLbl.Size = new System.Drawing.Size(302, 32);
            this.returnComboBoxLbl.TabIndex = 1;
            this.returnComboBoxLbl.Text = "Select Item ID to return";
            // 
            // returnComboBox
            // 
            this.returnComboBox.DataSource = this.tblborrowBindingSource;
            this.returnComboBox.DisplayMember = "ProductID";
            this.returnComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnComboBox.FormattingEnabled = true;
            this.returnComboBox.Location = new System.Drawing.Point(352, 51);
            this.returnComboBox.Name = "returnComboBox";
            this.returnComboBox.Size = new System.Drawing.Size(121, 40);
            this.returnComboBox.TabIndex = 2;
            this.returnComboBox.ValueMember = "TransactionID";
            // 
            // tblborrowBindingSource
            // 
            this.tblborrowBindingSource.DataMember = "tbl_borrow";
            this.tblborrowBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_borrowTableAdapter
            // 
            this.tbl_borrowTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spDisplayBorrowedBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(793, 252);
            this.dataGridView1.TabIndex = 3;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 85;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 85;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "Due Date";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due Date";
            this.dueDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // spDisplayBorrowedBindingSource1
            // 
            this.spDisplayBorrowedBindingSource1.DataMember = "spDisplayBorrowed";
            this.spDisplayBorrowedBindingSource1.DataSource = this.libraryDBDataSet3;
            // 
            // libraryDBDataSet3
            // 
            this.libraryDBDataSet3.DataSetName = "LibraryDBDataSet3";
            this.libraryDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spDisplayBorrowedBindingSource
            // 
            this.spDisplayBorrowedBindingSource.DataMember = "spDisplayBorrowed";
            this.spDisplayBorrowedBindingSource.DataSource = this.libraryDBDataSet2;
            // 
            // libraryDBDataSet2
            // 
            this.libraryDBDataSet2.DataSetName = "LibraryDBDataSet2";
            this.libraryDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spDisplayBorrowedTableAdapter
            // 
            this.spDisplayBorrowedTableAdapter.ClearBeforeFill = true;
            // 
            // spDisplayBorrowedTableAdapter1
            // 
            this.spDisplayBorrowedTableAdapter1.ClearBeforeFill = true;
            // 
            // returnFrm
            // 
            this.AcceptButton = this.returnBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(824, 429);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.returnComboBox);
            this.Controls.Add(this.returnComboBoxLbl);
            this.Controls.Add(this.returnBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "returnFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Systems 1.0 - Returns";
            this.Load += new System.EventHandler(this.returnFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblborrowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDisplayBorrowedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDisplayBorrowedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label returnComboBoxLbl;
        private System.Windows.Forms.ComboBox returnComboBox;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource tblborrowBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_borrowTableAdapter tbl_borrowTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDBDataSet2 libraryDBDataSet2;
        private System.Windows.Forms.BindingSource spDisplayBorrowedBindingSource;
        private LibraryDBDataSet2TableAdapters.spDisplayBorrowedTableAdapter spDisplayBorrowedTableAdapter;
        private LibraryDBDataSet3 libraryDBDataSet3;
        private System.Windows.Forms.BindingSource spDisplayBorrowedBindingSource1;
        private LibraryDBDataSet3TableAdapters.spDisplayBorrowedTableAdapter spDisplayBorrowedTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
    }
}