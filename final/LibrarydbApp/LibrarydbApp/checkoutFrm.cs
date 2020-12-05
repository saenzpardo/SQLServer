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
    public partial class checkoutFrm : Form
    {

        public checkoutFrm()
        {
            InitializeComponent();

            // show todays date and return date in labels
            DateTime now = DateTime.Now;
            string showDate = now.ToString("dddd, MMMM dd yyyy");
            currentDateLbl.Text = showDate;
            DateTime returnDate = now.AddDays(20);
            showDueDateLbl.Text = returnDate.ToString("dddd, MMMM dd yyyy");
        }

        private void checkoutDateLbl_Click(object sender, EventArgs e)
        {

        }

        private void checkoutFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_product' table. You can move, or remove it, as needed.
            this.tbl_productTableAdapter.Fill(this.libraryDBDataSet.tbl_product);
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_customer' table. You can move, or remove it, as needed.
            this.tbl_customerTableAdapter.Fill(this.libraryDBDataSet.tbl_customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // retrieve system date
                DateTime myDate = DateTime.Now;
                
                int custID = (int)checkoutCustIDComboBox.SelectedValue;
                int productID = (int)checkoutProductIDComboBox.SelectedValue;
                DateTime dBorrowed = myDate.Date;
                // make date format useable                
                string dateBorrowed = dBorrowed.ToString("yyyy-MM-dd");
                DateTime dDue = dBorrowed.AddDays(20);
                string dateDue = dDue.ToString("yyyy-MM-dd");
                // DB connection string
                String connectionString = Properties.Settings.Default.LibraryDBConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "spNewCheckout";

                SqlParameter paramCustAdd = new SqlParameter();
                paramCustAdd.ParameterName = "@CustomerID";
                paramCustAdd.Value = custID;
                sqlCmd.Parameters.Add(paramCustAdd);

                SqlParameter paramProductAdd = new SqlParameter();
                paramProductAdd.ParameterName = "@ProductID";
                paramProductAdd.Value = productID;
                sqlCmd.Parameters.Add(paramProductAdd);

                SqlParameter paramDateBorrowed = new SqlParameter();
                paramDateBorrowed.ParameterName = "@DateBorrowed";
                paramDateBorrowed.Value = dateBorrowed;
                sqlCmd.Parameters.Add(paramDateBorrowed);

                SqlParameter paramDateDue = new SqlParameter();
                paramDateDue.ParameterName = "@DateDue";
                paramDateDue.Value = dateDue;
                sqlCmd.Parameters.Add(paramDateDue);

                // Do the command
                sqlCmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Success! Product checked out.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        private void dueDateLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
