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
    public partial class mainMenuFrm : Form
    {
        public mainMenuFrm()
        {
            InitializeComponent();
        }

        private void viewInventoryBtn_Click(object sender, EventArgs e)
        {
            inventoryFrm form = new inventoryFrm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerSearchFrm form = new customerSearchFrm();
            form.ShowDialog();
        }

        private void searchInvtentoryBtn_Click(object sender, EventArgs e)
        {
            searchInventoryFrm form = new searchInventoryFrm();
            form.ShowDialog();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            adminFrm form = new adminFrm();
            form.ShowDialog();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            checkoutFrm form = new checkoutFrm();
            form.ShowDialog();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            returnFrm form = new returnFrm();
            form.ShowDialog();
        }
    }
}
