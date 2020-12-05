
namespace LibrarydbApp
{
    partial class adminFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.newCustButton = new System.Windows.Forms.Button();
            this.addCustZipTextBox = new System.Windows.Forms.TextBox();
            this.addCustStateTextBox = new System.Windows.Forms.TextBox();
            this.addCustCityTextBox = new System.Windows.Forms.TextBox();
            this.addCustAddressTextBox = new System.Windows.Forms.TextBox();
            this.addCustPhoneTextBox = new System.Windows.Forms.TextBox();
            this.addCustLastNameTextBox = new System.Windows.Forms.TextBox();
            this.addCustFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.zipLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.addrLbl = new System.Windows.Forms.Label();
            this.phoneNumLbl = new System.Windows.Forms.Label();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.pnlLabel = new System.Windows.Forms.Label();
            this.rmvCustLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removeCustomerTextBox = new System.Windows.Forms.TextBox();
            this.rmvCustPnlLbl = new System.Windows.Forms.Label();
            this.removeCustBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.removeProductTextBox = new System.Windows.Forms.TextBox();
            this.prodcutIDLbl = new System.Windows.Forms.Label();
            this.removeProductBtn = new System.Windows.Forms.Button();
            this.removeProductLbl = new System.Windows.Forms.Label();
            this.libraryDBDataSet = new LibrarydbApp.LibraryDBDataSet();
            this.tblcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_customerTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_customerTableAdapter();
            this.tblcustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblauthorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_authorTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_authorTableAdapter();
            this.tblproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_productTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_productTableAdapter();
            this.tblpublisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_publisherTableAdapter = new LibrarydbApp.LibraryDBDataSetTableAdapters.tbl_publisherTableAdapter();
            this.addInventoryBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblauthorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpublisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.newCustButton);
            this.panel1.Controls.Add(this.addCustZipTextBox);
            this.panel1.Controls.Add(this.addCustStateTextBox);
            this.panel1.Controls.Add(this.addCustCityTextBox);
            this.panel1.Controls.Add(this.addCustAddressTextBox);
            this.panel1.Controls.Add(this.addCustPhoneTextBox);
            this.panel1.Controls.Add(this.addCustLastNameTextBox);
            this.panel1.Controls.Add(this.addCustFirstNameTextBox);
            this.panel1.Controls.Add(this.zipLbl);
            this.panel1.Controls.Add(this.stateLbl);
            this.panel1.Controls.Add(this.cityLbl);
            this.panel1.Controls.Add(this.addrLbl);
            this.panel1.Controls.Add(this.phoneNumLbl);
            this.panel1.Controls.Add(this.lNameLbl);
            this.panel1.Controls.Add(this.fNameLbl);
            this.panel1.Location = new System.Drawing.Point(19, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 493);
            this.panel1.TabIndex = 0;
            // 
            // newCustButton
            // 
            this.newCustButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.newCustButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCustButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newCustButton.Location = new System.Drawing.Point(116, 376);
            this.newCustButton.Name = "newCustButton";
            this.newCustButton.Size = new System.Drawing.Size(205, 56);
            this.newCustButton.TabIndex = 14;
            this.newCustButton.Text = "Submit";
            this.newCustButton.UseVisualStyleBackColor = false;
            this.newCustButton.Click += new System.EventHandler(this.newCustButton_Click);
            // 
            // addCustZipTextBox
            // 
            this.addCustZipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustZipTextBox.Location = new System.Drawing.Point(185, 308);
            this.addCustZipTextBox.Name = "addCustZipTextBox";
            this.addCustZipTextBox.Size = new System.Drawing.Size(268, 35);
            this.addCustZipTextBox.TabIndex = 13;
            // 
            // addCustStateTextBox
            // 
            this.addCustStateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustStateTextBox.Location = new System.Drawing.Point(185, 259);
            this.addCustStateTextBox.Name = "addCustStateTextBox";
            this.addCustStateTextBox.Size = new System.Drawing.Size(268, 35);
            this.addCustStateTextBox.TabIndex = 12;
            // 
            // addCustCityTextBox
            // 
            this.addCustCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustCityTextBox.Location = new System.Drawing.Point(185, 210);
            this.addCustCityTextBox.Name = "addCustCityTextBox";
            this.addCustCityTextBox.Size = new System.Drawing.Size(268, 35);
            this.addCustCityTextBox.TabIndex = 11;
            // 
            // addCustAddressTextBox
            // 
            this.addCustAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustAddressTextBox.Location = new System.Drawing.Point(185, 162);
            this.addCustAddressTextBox.Name = "addCustAddressTextBox";
            this.addCustAddressTextBox.Size = new System.Drawing.Size(268, 35);
            this.addCustAddressTextBox.TabIndex = 10;
            // 
            // addCustPhoneTextBox
            // 
            this.addCustPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustPhoneTextBox.Location = new System.Drawing.Point(185, 116);
            this.addCustPhoneTextBox.Name = "addCustPhoneTextBox";
            this.addCustPhoneTextBox.Size = new System.Drawing.Size(268, 35);
            this.addCustPhoneTextBox.TabIndex = 9;
            // 
            // addCustLastNameTextBox
            // 
            this.addCustLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustLastNameTextBox.Location = new System.Drawing.Point(185, 70);
            this.addCustLastNameTextBox.Name = "addCustLastNameTextBox";
            this.addCustLastNameTextBox.Size = new System.Drawing.Size(268, 35);
            this.addCustLastNameTextBox.TabIndex = 8;
            // 
            // addCustFirstNameTextBox
            // 
            this.addCustFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustFirstNameTextBox.Location = new System.Drawing.Point(185, 24);
            this.addCustFirstNameTextBox.Name = "addCustFirstNameTextBox";
            this.addCustFirstNameTextBox.Size = new System.Drawing.Size(268, 35);
            this.addCustFirstNameTextBox.TabIndex = 7;
            // 
            // zipLbl
            // 
            this.zipLbl.AutoSize = true;
            this.zipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zipLbl.Location = new System.Drawing.Point(0, 313);
            this.zipLbl.Name = "zipLbl";
            this.zipLbl.Size = new System.Drawing.Size(114, 29);
            this.zipLbl.TabIndex = 6;
            this.zipLbl.Text = "ZIP Code";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stateLbl.Location = new System.Drawing.Point(2, 265);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(68, 29);
            this.stateLbl.TabIndex = 5;
            this.stateLbl.Text = "State";
            this.stateLbl.Click += new System.EventHandler(this.stateLbl_Click);
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cityLbl.Location = new System.Drawing.Point(2, 212);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(53, 29);
            this.cityLbl.TabIndex = 4;
            this.cityLbl.Text = "City";
            // 
            // addrLbl
            // 
            this.addrLbl.AutoSize = true;
            this.addrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addrLbl.Location = new System.Drawing.Point(2, 163);
            this.addrLbl.Name = "addrLbl";
            this.addrLbl.Size = new System.Drawing.Size(102, 29);
            this.addrLbl.TabIndex = 3;
            this.addrLbl.Text = "Address";
            // 
            // phoneNumLbl
            // 
            this.phoneNumLbl.AutoSize = true;
            this.phoneNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneNumLbl.Location = new System.Drawing.Point(0, 116);
            this.phoneNumLbl.Name = "phoneNumLbl";
            this.phoneNumLbl.Size = new System.Drawing.Size(176, 29);
            this.phoneNumLbl.TabIndex = 2;
            this.phoneNumLbl.Text = "Phone Number";
            this.phoneNumLbl.Click += new System.EventHandler(this.phoneNumLbl_Click);
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lNameLbl.Location = new System.Drawing.Point(3, 68);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(128, 29);
            this.lNameLbl.TabIndex = 1;
            this.lNameLbl.Text = "Last Name";
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fNameLbl.Location = new System.Drawing.Point(0, 22);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(131, 29);
            this.fNameLbl.TabIndex = 0;
            this.fNameLbl.Text = "First Name";
            // 
            // pnlLabel
            // 
            this.pnlLabel.AutoSize = true;
            this.pnlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlLabel.Location = new System.Drawing.Point(73, 24);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(296, 37);
            this.pnlLabel.TabIndex = 1;
            this.pnlLabel.Text = "Add New Customer";
            // 
            // rmvCustLbl
            // 
            this.rmvCustLbl.AutoSize = true;
            this.rmvCustLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmvCustLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rmvCustLbl.Location = new System.Drawing.Point(641, 24);
            this.rmvCustLbl.Name = "rmvCustLbl";
            this.rmvCustLbl.Size = new System.Drawing.Size(281, 37);
            this.rmvCustLbl.TabIndex = 2;
            this.rmvCustLbl.Text = "Remove Customer";
            this.rmvCustLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.removeCustomerTextBox);
            this.panel2.Controls.Add(this.rmvCustPnlLbl);
            this.panel2.Controls.Add(this.removeCustBtn);
            this.panel2.Location = new System.Drawing.Point(568, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 136);
            this.panel2.TabIndex = 3;
            // 
            // removeCustomerTextBox
            // 
            this.removeCustomerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCustomerTextBox.Location = new System.Drawing.Point(186, 12);
            this.removeCustomerTextBox.Name = "removeCustomerTextBox";
            this.removeCustomerTextBox.Size = new System.Drawing.Size(176, 35);
            this.removeCustomerTextBox.TabIndex = 15;
            // 
            // rmvCustPnlLbl
            // 
            this.rmvCustPnlLbl.AutoSize = true;
            this.rmvCustPnlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmvCustPnlLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rmvCustPnlLbl.Location = new System.Drawing.Point(18, 22);
            this.rmvCustPnlLbl.Name = "rmvCustPnlLbl";
            this.rmvCustPnlLbl.Size = new System.Drawing.Size(175, 35);
            this.rmvCustPnlLbl.TabIndex = 16;
            this.rmvCustPnlLbl.Text = "Customer ID";
            // 
            // removeCustBtn
            // 
            this.removeCustBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.removeCustBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCustBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeCustBtn.Location = new System.Drawing.Point(59, 61);
            this.removeCustBtn.Name = "removeCustBtn";
            this.removeCustBtn.Size = new System.Drawing.Size(205, 56);
            this.removeCustBtn.TabIndex = 15;
            this.removeCustBtn.Text = "Delete Customer";
            this.removeCustBtn.UseVisualStyleBackColor = false;
            this.removeCustBtn.Click += new System.EventHandler(this.removeCustBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.removeProductTextBox);
            this.panel3.Controls.Add(this.prodcutIDLbl);
            this.panel3.Controls.Add(this.removeProductBtn);
            this.panel3.Location = new System.Drawing.Point(568, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 148);
            this.panel3.TabIndex = 18;
            // 
            // removeProductTextBox
            // 
            this.removeProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProductTextBox.Location = new System.Drawing.Point(201, 15);
            this.removeProductTextBox.Name = "removeProductTextBox";
            this.removeProductTextBox.Size = new System.Drawing.Size(176, 35);
            this.removeProductTextBox.TabIndex = 15;
            // 
            // prodcutIDLbl
            // 
            this.prodcutIDLbl.AutoSize = true;
            this.prodcutIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodcutIDLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodcutIDLbl.Location = new System.Drawing.Point(33, 18);
            this.prodcutIDLbl.Name = "prodcutIDLbl";
            this.prodcutIDLbl.Size = new System.Drawing.Size(125, 29);
            this.prodcutIDLbl.TabIndex = 16;
            this.prodcutIDLbl.Text = "Product ID";
            // 
            // removeProductBtn
            // 
            this.removeProductBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.removeProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProductBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeProductBtn.Location = new System.Drawing.Point(78, 67);
            this.removeProductBtn.Name = "removeProductBtn";
            this.removeProductBtn.Size = new System.Drawing.Size(205, 56);
            this.removeProductBtn.TabIndex = 15;
            this.removeProductBtn.Text = "Delete Product";
            this.removeProductBtn.UseVisualStyleBackColor = false;
            this.removeProductBtn.Click += new System.EventHandler(this.removeProductBtn_Click);
            // 
            // removeProductLbl
            // 
            this.removeProductLbl.AutoSize = true;
            this.removeProductLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProductLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeProductLbl.Location = new System.Drawing.Point(659, 243);
            this.removeProductLbl.Name = "removeProductLbl";
            this.removeProductLbl.Size = new System.Drawing.Size(253, 37);
            this.removeProductLbl.TabIndex = 17;
            this.removeProductLbl.Text = "Remove Product";
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcustomerBindingSource
            // 
            this.tblcustomerBindingSource.DataMember = "tbl_customer";
            this.tblcustomerBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // tbl_customerTableAdapter
            // 
            this.tbl_customerTableAdapter.ClearBeforeFill = true;
            // 
            // tblcustomerBindingSource1
            // 
            this.tblcustomerBindingSource1.DataMember = "tbl_customer";
            this.tblcustomerBindingSource1.DataSource = this.libraryDBDataSet;
            // 
            // tblauthorBindingSource
            // 
            this.tblauthorBindingSource.DataMember = "tbl_author";
            this.tblauthorBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // tbl_authorTableAdapter
            // 
            this.tbl_authorTableAdapter.ClearBeforeFill = true;
            // 
            // tblproductBindingSource
            // 
            this.tblproductBindingSource.DataMember = "tbl_product";
            this.tblproductBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // tbl_productTableAdapter
            // 
            this.tbl_productTableAdapter.ClearBeforeFill = true;
            // 
            // tblpublisherBindingSource
            // 
            this.tblpublisherBindingSource.DataMember = "tbl_publisher";
            this.tblpublisherBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // tbl_publisherTableAdapter
            // 
            this.tbl_publisherTableAdapter.ClearBeforeFill = true;
            // 
            // addInventoryBtn
            // 
            this.addInventoryBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addInventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addInventoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInventoryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addInventoryBtn.Location = new System.Drawing.Point(629, 466);
            this.addInventoryBtn.Name = "addInventoryBtn";
            this.addInventoryBtn.Size = new System.Drawing.Size(240, 81);
            this.addInventoryBtn.TabIndex = 19;
            this.addInventoryBtn.Text = "Add Product to Inventory";
            this.addInventoryBtn.UseVisualStyleBackColor = false;
            this.addInventoryBtn.Click += new System.EventHandler(this.addInventoryBtn_Click);
            // 
            // adminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1024, 595);
            this.Controls.Add(this.addInventoryBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.removeProductLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rmvCustLbl);
            this.Controls.Add(this.pnlLabel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Systems 1.0 - Admin";
            this.Load += new System.EventHandler(this.adminFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblauthorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpublisherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label zipLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label addrLbl;
        private System.Windows.Forms.Label phoneNumLbl;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label pnlLabel;
        private System.Windows.Forms.Button newCustButton;
        private System.Windows.Forms.TextBox addCustZipTextBox;
        private System.Windows.Forms.TextBox addCustStateTextBox;
        private System.Windows.Forms.TextBox addCustCityTextBox;
        private System.Windows.Forms.TextBox addCustAddressTextBox;
        private System.Windows.Forms.TextBox addCustPhoneTextBox;
        private System.Windows.Forms.TextBox addCustLastNameTextBox;
        private System.Windows.Forms.TextBox addCustFirstNameTextBox;
        private System.Windows.Forms.Label rmvCustLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox removeCustomerTextBox;
        private System.Windows.Forms.Label rmvCustPnlLbl;
        private System.Windows.Forms.Button removeCustBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox removeProductTextBox;
        private System.Windows.Forms.Label prodcutIDLbl;
        private System.Windows.Forms.Button removeProductBtn;
        private System.Windows.Forms.Label removeProductLbl;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_customerTableAdapter tbl_customerTableAdapter;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource1;
        private System.Windows.Forms.BindingSource tblauthorBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_authorTableAdapter tbl_authorTableAdapter;
        private System.Windows.Forms.BindingSource tblproductBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_productTableAdapter tbl_productTableAdapter;
        private System.Windows.Forms.BindingSource tblpublisherBindingSource;
        private LibraryDBDataSetTableAdapters.tbl_publisherTableAdapter tbl_publisherTableAdapter;
        private System.Windows.Forms.Button addInventoryBtn;
    }
}