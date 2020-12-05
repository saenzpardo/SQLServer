
namespace LibrarydbApp
{
    partial class searchInventoryFrm
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
            this.titleSearchLabel = new System.Windows.Forms.Label();
            this.titleSearchTextBox = new System.Windows.Forms.TextBox();
            this.srcTitleBtn = new System.Windows.Forms.Button();
            this.tblproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new LibrarydbApp.LibraryDBDataSet();
            this.tbl_productTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_productTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblproductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_publisherTableAdapter1 = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_publisherTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleSearchLabel
            // 
            this.titleSearchLabel.AutoSize = true;
            this.titleSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSearchLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleSearchLabel.Location = new System.Drawing.Point(181, 36);
            this.titleSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleSearchLabel.Name = "titleSearchLabel";
            this.titleSearchLabel.Size = new System.Drawing.Size(175, 32);
            this.titleSearchLabel.TabIndex = 0;
            this.titleSearchLabel.Text = "Search Title:";
            this.titleSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleSearchLabel.Click += new System.EventHandler(this.titleSearchLabel_Click);
            // 
            // titleSearchTextBox
            // 
            this.titleSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSearchTextBox.Location = new System.Drawing.Point(385, 36);
            this.titleSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleSearchTextBox.Name = "titleSearchTextBox";
            this.titleSearchTextBox.Size = new System.Drawing.Size(193, 39);
            this.titleSearchTextBox.TabIndex = 1;
            // 
            // srcTitleBtn
            // 
            this.srcTitleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.srcTitleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.srcTitleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcTitleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.srcTitleBtn.Location = new System.Drawing.Point(623, 25);
            this.srcTitleBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.srcTitleBtn.Name = "srcTitleBtn";
            this.srcTitleBtn.Size = new System.Drawing.Size(245, 64);
            this.srcTitleBtn.TabIndex = 2;
            this.srcTitleBtn.Text = "Search";
            this.srcTitleBtn.UseVisualStyleBackColor = false;
            this.srcTitleBtn.Click += new System.EventHandler(this.srcTitleBtn_Click);
            // 
            // tblproductBindingSource
            // 
            this.tblproductBindingSource.DataMember = "tbl_product";
            this.tblproductBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_productTableAdapter
            // 
            this.tbl_productTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.mediaIDDataGridViewTextBoxColumn,
            this.productAuthorDataGridViewTextBoxColumn,
            this.productGenreDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblproductBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 378);
            this.dataGridView1.TabIndex = 3;
            // 
            // tblproductBindingSource1
            // 
            this.tblproductBindingSource1.DataMember = "tbl_product";
            this.tblproductBindingSource1.DataSource = this.libraryDBDataSet;
            // 
            // tbl_publisherTableAdapter1
            // 
            this.tbl_publisherTableAdapter1.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // mediaIDDataGridViewTextBoxColumn
            // 
            this.mediaIDDataGridViewTextBoxColumn.DataPropertyName = "MediaID";
            this.mediaIDDataGridViewTextBoxColumn.HeaderText = "MediaID";
            this.mediaIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mediaIDDataGridViewTextBoxColumn.Name = "mediaIDDataGridViewTextBoxColumn";
            this.mediaIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // productAuthorDataGridViewTextBoxColumn
            // 
            this.productAuthorDataGridViewTextBoxColumn.DataPropertyName = "ProductAuthor";
            this.productAuthorDataGridViewTextBoxColumn.HeaderText = "ProductAuthor";
            this.productAuthorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productAuthorDataGridViewTextBoxColumn.Name = "productAuthorDataGridViewTextBoxColumn";
            this.productAuthorDataGridViewTextBoxColumn.Width = 85;
            // 
            // productGenreDataGridViewTextBoxColumn
            // 
            this.productGenreDataGridViewTextBoxColumn.DataPropertyName = "ProductGenre";
            this.productGenreDataGridViewTextBoxColumn.HeaderText = "ProductGenre";
            this.productGenreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productGenreDataGridViewTextBoxColumn.Name = "productGenreDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // searchInventoryFrm
            // 
            this.AcceptButton = this.srcTitleBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1122, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.srcTitleBtn);
            this.Controls.Add(this.titleSearchTextBox);
            this.Controls.Add(this.titleSearchLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "searchInventoryFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchInventoryFrm";
            this.Load += new System.EventHandler(this.searchInventoryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleSearchLabel;
        private System.Windows.Forms.TextBox titleSearchTextBox;
        private System.Windows.Forms.Button srcTitleBtn;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource tblproductBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_productTableAdapter tbl_productTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDBDataSetTableAdapters.tbl_publisherTableAdapter tbl_publisherTableAdapter1;
        private System.Windows.Forms.BindingSource tblproductBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
    }
}