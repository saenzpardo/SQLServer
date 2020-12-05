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
    public partial class customerSearchFrm : Form
    {
        public customerSearchFrm()
        {
            InitializeComponent();
        }

        private void customerSearchFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_customer' table. You can move, or remove it, as needed.
            this.tbl_customerTableAdapter.Fill(this.libraryDBDataSet.tbl_customer);

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

        private void custSearchViewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String custName = custSearchTextBox.Text;
                String connectionString = Properties.Settings.Default.LibraryDBConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT * FROM tbl_customer WHERE LastName LIKE '%' + @NameSearch + '%'";

                SqlParameter paramCustSearch = new SqlParameter();
                paramCustSearch.ParameterName = "@NameSearch";
                paramCustSearch.Value = custName;
                sqlCmd.Parameters.Add(paramCustSearch);

                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.Refresh();
                // resultsView.DataSource = dtRecord;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
