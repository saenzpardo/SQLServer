
namespace LibrarydbApp
{
    partial class inventoryFrm
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
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new LibrarydbApp.LibraryDBDataSet();
            this.tbl_productTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_productTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoGenerateColumns = false;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.mediaIDDataGridViewTextBoxColumn,
            this.productAuthorDataGridViewTextBoxColumn,
            this.productGenreDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn});
            this.inventoryGridView.DataSource = this.tblproductBindingSource;
            this.inventoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inventoryGridView.Location = new System.Drawing.Point(0, 0);
            this.inventoryGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.RowHeadersWidth = 62;
            this.inventoryGridView.Size = new System.Drawing.Size(1200, 692);
            this.inventoryGridView.TabIndex = 0;
            this.inventoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.productAuthorDataGridViewTextBoxColumn.Width = 150;
            // 
            // productGenreDataGridViewTextBoxColumn
            // 
            this.productGenreDataGridViewTextBoxColumn.DataPropertyName = "ProductGenre";
            this.productGenreDataGridViewTextBoxColumn.HeaderText = "ProductGenre";
            this.productGenreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productGenreDataGridViewTextBoxColumn.Name = "productGenreDataGridViewTextBoxColumn";
            this.productGenreDataGridViewTextBoxColumn.Width = 150;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 400;
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
            // inventoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.inventoryGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "inventoryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Systems 1.0 - Inventory";
            this.Load += new System.EventHandler(this.inventoryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryGridView;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource tblproductBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_productTableAdapter tbl_productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
    }
}