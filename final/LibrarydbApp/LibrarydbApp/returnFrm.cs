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
    public partial class returnFrm : Form
    {
        public returnFrm()
        {
            InitializeComponent();
        }

        private void returnFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet3.spDisplayBorrowed' table. You can move, or remove it, as needed.
            this.spDisplayBorrowedTableAdapter1.Fill(this.libraryDBDataSet3.spDisplayBorrowed);
            // TODO: This line of code loads data into the 'libraryDBDataSet2.spDisplayBorrowed' table. You can move, or remove it, as needed.
            this.spDisplayBorrowedTableAdapter.Fill(this.libraryDBDataSet2.spDisplayBorrowed);
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_borrow' table. You can move, or remove it, as needed.
            this.tbl_borrowTableAdapter.Fill(this.libraryDBDataSet.tbl_borrow);

            // load custom formatting for data grid view
            dataGridView1.GridColor = Color.DodgerBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.BackgroundColor = Color.LightGray;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.BlueViolet;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // retrieve system date
                DateTime myDate = DateTime.Now;

                int returnID = (int)returnComboBox.SelectedValue;
                
                DateTime dReturned = myDate.Date;
                // make date format useable                
                string dateReturned = dReturned.ToString("yyyy-MM-dd");

                // DB connection string
                String connectionString = Properties.Settings.Default.LibraryDBConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                //  sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "UPDATE tbl_borrow SET DateReturned = @DateReturned WHERE TransactionID = @TransactionID";

                SqlParameter paramProductID = new SqlParameter();
                paramProductID.ParameterName = "@TransactionID";
                paramProductID.Value = returnID;
                sqlCmd.Parameters.Add(paramProductID);

                SqlParameter paramDateReturned = new SqlParameter();
                paramDateReturned.ParameterName = "@DateReturned";
                paramDateReturned.Value = dateReturned;
                sqlCmd.Parameters.Add(paramDateReturned);

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Success! Customer deleted from system.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_borrowTableAdapter.FillBy(this.libraryDBDataSet.tbl_borrow);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
