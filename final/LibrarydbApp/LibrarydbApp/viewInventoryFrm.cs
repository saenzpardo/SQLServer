using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarydbApp
{
    public partial class inventoryFrm : Form
    {
        public inventoryFrm()
        {
            InitializeComponent();
        }

        private void inventoryFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.tbl_product' table. You can move, or remove it, as needed.
            this.tbl_productTableAdapter.Fill(this.libraryDBDataSet.tbl_product);

            // load custom formatting for data grid view
            inventoryGridView.GridColor = Color.DodgerBlue;
            inventoryGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            inventoryGridView.BackgroundColor = Color.LightGray;

            inventoryGridView.DefaultCellStyle.SelectionBackColor = Color.BlueViolet;
            inventoryGridView.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            inventoryGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

            inventoryGridView.RowsDefaultCellStyle.BackColor = Color.Bisque;
            inventoryGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
