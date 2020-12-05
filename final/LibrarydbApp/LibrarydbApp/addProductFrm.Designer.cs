
namespace LibrarydbApp
{
    partial class addProductFrm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newProductAuthorCombo = new System.Windows.Forms.ComboBox();
            this.tblauthorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new LibrarydbApp.LibraryDBDataSet();
            this.newProductMediaTypeCombo = new System.Windows.Forms.ComboBox();
            this.tblmediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newTitleTextBox = new System.Windows.Forms.TextBox();
            this.newProductGenreTextBox = new System.Windows.Forms.TextBox();
            this.tbl_mediaTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_mediaTableAdapter();
            this.tbl_authorTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_authorTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblauthorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.noViewLbl = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblauthorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmediaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblauthorBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLbl.Location = new System.Drawing.Point(22, 30);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(84, 38);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.authorLbl.Location = new System.Drawing.Point(22, 81);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(160, 38);
            this.authorLbl.TabIndex = 1;
            this.authorLbl.Text = "Author ID";
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genreLbl.Location = new System.Drawing.Point(22, 139);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(113, 38);
            this.genreLbl.TabIndex = 2;
            this.genreLbl.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Media Type";
            // 
            // newProductAuthorCombo
            // 
            this.newProductAuthorCombo.DataSource = this.tblauthorBindingSource;
            this.newProductAuthorCombo.DisplayMember = "AuthorID";
            this.newProductAuthorCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductAuthorCombo.FormattingEnabled = true;
            this.newProductAuthorCombo.Location = new System.Drawing.Point(201, 83);
            this.newProductAuthorCombo.Name = "newProductAuthorCombo";
            this.newProductAuthorCombo.Size = new System.Drawing.Size(121, 37);
            this.newProductAuthorCombo.TabIndex = 4;
            this.newProductAuthorCombo.ValueMember = "AuthorID";
            // 
            // tblauthorBindingSource
            // 
            this.tblauthorBindingSource.DataMember = "tbl_author";
            this.tblauthorBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newProductMediaTypeCombo
            // 
            this.newProductMediaTypeCombo.DataSource = this.tblmediaBindingSource;
            this.newProductMediaTypeCombo.DisplayMember = "MediaType";
            this.newProductMediaTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductMediaTypeCombo.FormattingEnabled = true;
            this.newProductMediaTypeCombo.Location = new System.Drawing.Point(201, 192);
            this.newProductMediaTypeCombo.Name = "newProductMediaTypeCombo";
            this.newProductMediaTypeCombo.Size = new System.Drawing.Size(121, 37);
            this.newProductMediaTypeCombo.TabIndex = 5;
            this.newProductMediaTypeCombo.ValueMember = "MediaID";
            // 
            // tblmediaBindingSource
            // 
            this.tblmediaBindingSource.DataMember = "tbl_media";
            this.tblmediaBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // newTitleTextBox
            // 
            this.newTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTitleTextBox.Location = new System.Drawing.Point(201, 28);
            this.newTitleTextBox.Name = "newTitleTextBox";
            this.newTitleTextBox.Size = new System.Drawing.Size(275, 35);
            this.newTitleTextBox.TabIndex = 6;
            // 
            // newProductGenreTextBox
            // 
            this.newProductGenreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductGenreTextBox.Location = new System.Drawing.Point(201, 136);
            this.newProductGenreTextBox.Name = "newProductGenreTextBox";
            this.newProductGenreTextBox.Size = new System.Drawing.Size(275, 42);
            this.newProductGenreTextBox.TabIndex = 7;
            // 
            // tbl_mediaTableAdapter
            // 
            this.tbl_mediaTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_authorTableAdapter
            // 
            this.tbl_authorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.publishingCompanyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblauthorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(81, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(763, 238);
            this.dataGridView1.TabIndex = 8;
            // 
            // tblauthorBindingSource1
            // 
            this.tblauthorBindingSource1.DataMember = "tbl_author";
            this.tblauthorBindingSource1.DataSource = this.libraryDBDataSet;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.noViewLbl);
            this.panel1.Location = new System.Drawing.Point(512, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 137);
            this.panel1.TabIndex = 9;
            // 
            // noViewLbl
            // 
            this.noViewLbl.AutoSize = true;
            this.noViewLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noViewLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.noViewLbl.Location = new System.Drawing.Point(4, 17);
            this.noViewLbl.Name = "noViewLbl";
            this.noViewLbl.Size = new System.Drawing.Size(399, 100);
            this.noViewLbl.TabIndex = 10;
            this.noViewLbl.Text = "Please be sure to select the Author ID below.\r\nI was unable to get my view to wor" +
    "k to \r\nproperly display the author\'s first and last\r\nname in the combo box.\r\n";
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProductBtn.Location = new System.Drawing.Point(602, 192);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(242, 82);
            this.addProductBtn.TabIndex = 10;
            this.addProductBtn.Text = "Submit";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 75;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 75;
            // 
            // publishingCompanyDataGridViewTextBoxColumn
            // 
            this.publishingCompanyDataGridViewTextBoxColumn.DataPropertyName = "PublishingCompany";
            this.publishingCompanyDataGridViewTextBoxColumn.HeaderText = "PublishingCompany";
            this.publishingCompanyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.publishingCompanyDataGridViewTextBoxColumn.Name = "publishingCompanyDataGridViewTextBoxColumn";
            this.publishingCompanyDataGridViewTextBoxColumn.Width = 200;
            // 
            // addProductFrm
            // 
            this.AcceptButton = this.addProductBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(940, 569);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.newProductGenreTextBox);
            this.Controls.Add(this.newTitleTextBox);
            this.Controls.Add(this.newProductMediaTypeCombo);
            this.Controls.Add(this.newProductAuthorCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.titleLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addProductFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Systems 1.0 - Add Product";
            this.Load += new System.EventHandler(this.addProductFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblauthorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmediaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblauthorBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox newProductAuthorCombo;
        private System.Windows.Forms.ComboBox newProductMediaTypeCombo;
        private System.Windows.Forms.TextBox newTitleTextBox;
        private System.Windows.Forms.TextBox newProductGenreTextBox;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource tblmediaBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_mediaTableAdapter tbl_mediaTableAdapter;
        private System.Windows.Forms.BindingSource tblauthorBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_authorTableAdapter tbl_authorTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblauthorBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label noViewLbl;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishingCompanyDataGridViewTextBoxColumn;
    }
}