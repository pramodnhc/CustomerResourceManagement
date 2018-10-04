using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* Form1 loginform = new Form1();
            loginform.Show();
            this.Close();*/
            Application.Exit();

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm addproductform = new AddProductForm();
            addproductform.Show();

        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProduct manageproduct = new ManageProduct();
            manageproduct.Show();
        }
    }
}
