using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamDoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
     
            InitializeComponent();
            this.MaximizeBox = true;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            closeWindow();
            frmProduit frmProduit = new frmProduit();
           
            frmProduit.MdiParent = this;
            frmProduit.MaximizeBox = true;
            frmProduit.Show();

        }


        private void closeWindow()
        {
            Form[] form = this.MdiChildren;

            foreach (Form item in form)
            {
                item.Close();
            }
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            closeWindow();
            frmCategories frmCategories = new frmCategories();

            frmCategories.MdiParent = this;
            frmCategories.MaximizeBox = true;
            frmCategories.Show();
        }
    }
}
