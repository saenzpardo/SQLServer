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
    public partial class addProductFrm : Form
    {
        public addProductFrm()
        {
            InitializeComponent();
        }

        private void addProductFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_author' table. You can move, or remove it, as needed.
            this.tbl_authorTableAdapter.Fill(this.libraryDBDataSet.tbl_author);
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_media' table. You can move, or remove it, as needed.
            this.tbl_mediaTableAdapter.Fill(this.libraryDBDataSet.tbl_media);

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

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // this is where you left off
                String newTitle = newTitleTextBox.Text;
                int newAuthor = (int)newProductAuthorCombo.SelectedValue;
                String newGenre = newProductGenreTextBox.Text;
                int newMediaType = (int)newProductMediaTypeCombo.SelectedValue;

                String connectionString = Properties.Settings.Default.LibraryDBConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "spNewProduct";

                SqlParameter paramTitleAdd = new SqlParameter();
                paramTitleAdd.ParameterName = "@ProductName";
                paramTitleAdd.Value = newTitle;
                sqlCmd.Parameters.Add(paramTitleAdd);

                SqlParameter paramAuthorAdd = new SqlParameter();
                paramAuthorAdd.ParameterName = "@ProductAuthor";
                paramAuthorAdd.Value = newAuthor;
                sqlCmd.Parameters.Add(paramAuthorAdd);

                SqlParameter paramGenreAdd = new SqlParameter();
                paramGenreAdd.ParameterName = "@ProductGenre";
                paramGenreAdd.Value = newGenre;
                sqlCmd.Parameters.Add(paramGenreAdd);

                SqlParameter paramMediaTypeAdd = new SqlParameter();
                paramMediaTypeAdd.ParameterName = "@MediaID";
                paramMediaTypeAdd.Value = newMediaType;
                sqlCmd.Parameters.Add(paramMediaTypeAdd);

                
                // Do the command
                sqlCmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Success! New product added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
