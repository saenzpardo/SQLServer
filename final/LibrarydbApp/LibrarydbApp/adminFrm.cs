using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarydbApp
{
    public partial class adminFrm : Form
    {
        public adminFrm()
        {
            InitializeComponent();
        }

        private void phoneNumLbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newCustButton_Click(object sender, EventArgs e)
        {

            try
            {
                
                String firstName = addCustFirstNameTextBox.Text;
                String lastName = addCustLastNameTextBox.Text;
                String phoneNum = addCustPhoneTextBox.Text;
                String address = addCustAddressTextBox.Text;
                String city = addCustCityTextBox.Text;
                String state = addCustStateTextBox.Text;
                String zip = addCustZipTextBox.Text;

                String connectionString = Properties.Settings.Default.LibraryDBConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "spNewCustomer";

                SqlParameter paramFirstNameAdd = new SqlParameter();
                paramFirstNameAdd.ParameterName = "@FirstName";
                paramFirstNameAdd.Value = firstName;
                sqlCmd.Parameters.Add(paramFirstNameAdd);

                SqlParameter paramLastNameAdd = new SqlParameter();
                paramLastNameAdd.ParameterName = "@LastName";
                paramLastNameAdd.Value = lastName;
                sqlCmd.Parameters.Add(paramLastNameAdd);

                SqlParameter paramPhoneNumAdd = new SqlParameter();
                paramPhoneNumAdd.ParameterName = "@CustomerPhoneNum";
                paramPhoneNumAdd.Value = phoneNum;
                sqlCmd.Parameters.Add(paramPhoneNumAdd);

                SqlParameter paramAddressAdd = new SqlParameter();
                paramAddressAdd.ParameterName = "@CustomerAddress";
                paramAddressAdd.Value = address;
                sqlCmd.Parameters.Add(paramAddressAdd);

                SqlParameter paramCityNameAdd = new SqlParameter();
                paramCityNameAdd.ParameterName = "@CustomerCity";
                paramCityNameAdd.Value = city;
                sqlCmd.Parameters.Add(paramCityNameAdd);

                SqlParameter paramStateNameAdd = new SqlParameter();
                paramStateNameAdd.ParameterName = "@CustomerState";
                paramStateNameAdd.Value = state;
                sqlCmd.Parameters.Add(paramStateNameAdd);

                SqlParameter paramZipAdd = new SqlParameter();
                paramZipAdd.ParameterName = "@CustomerZip";
                paramZipAdd.Value = zip;
                sqlCmd.Parameters.Add(paramZipAdd);

                // Do the command
                sqlCmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Success! New Customer Created.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void adminFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_publisher' table. You can move, or remove it, as needed.
            this.tbl_publisherTableAdapter.Fill(this.libraryDBDataSet.tbl_publisher);
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_product' table. You can move, or remove it, as needed.
            this.tbl_productTableAdapter.Fill(this.libraryDBDataSet.tbl_product);
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_author' table. You can move, or remove it, as needed.
            this.tbl_authorTableAdapter.Fill(this.libraryDBDataSet.tbl_author);
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_customer' table. You can move, or remove it, as needed.
            this.tbl_customerTableAdapter.Fill(this.libraryDBDataSet.tbl_customer);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_customerTableAdapter.FillBy(this.libraryDBDataSet.tbl_customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void removeCustBtn_Click(object sender, EventArgs e)
        {

            try
            {

                String inputID = removeCustomerTextBox.Text;

                String connectionString = Properties.Settings.Default.LibraryDBConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                //  sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "DELETE tbl_customer WHERE CustomerID = @CustomerID";

                SqlParameter paramInputID = new SqlParameter();
                paramInputID.ParameterName = "@CustomerID";
                paramInputID.Value = inputID;
                sqlCmd.Parameters.Add(paramInputID);

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Success! Customer Deleted.");

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            try
            {

                String inputID = removeProductTextBox.Text;

                String connectionString = Properties.Settings.Default.LibraryDBConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                //  sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "DELETE tbl_product WHERE ProductID = @ProductID";

                SqlParameter paramInputID = new SqlParameter();
                paramInputID.ParameterName = "@ProductID";
                paramInputID.Value = inputID;
                sqlCmd.Parameters.Add(paramInputID);

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Success! Product Removed from System.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addInventoryBtn_Click(object sender, EventArgs e)
        {
            addProductFrm form = new addProductFrm();
            form.ShowDialog();
        }

        private void stateLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
