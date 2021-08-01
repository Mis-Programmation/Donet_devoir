using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamDoNet.Service;
namespace ExamDoNet
{
    public partial class frmCategories : Form
    {
        private IService Iservice;

        public frmCategories()
        {
            InitializeComponent();

            Iservice = new ServiceImp();
            dgvCategorie.DataSource = Iservice.findAllCategories();

        }

        /// <summary>
        /// permet d'ajouter une categorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataChecker();

            categorie categorie = new categorie();

            categorie.nomCat = tbxCategorie.Text.Trim();

            Iservice.addcategorie(categorie);

            clearInputAndReloadFrame();
        }

        private void dataChecker()
        {
            if (tbxCategorie.Text.Trim().Equals(""))
            {
                MessageBox.Show(" le champs ne doit pas etre vide merci ");
                return;
            }
        }


        private void clearInputAndReloadFrame()
        {
            tbxCategorie.Text = String.Empty;
            dgvCategorie.DataSource = Iservice.findAllCategories();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dataChecker();
            int id = int.Parse(dgvCategorie.CurrentRow.Cells[0].Value.ToString());
            categorie categorie = new categorie();
            categorie.nomCat = dgvCategorie.CurrentRow.Cells[1].Value.ToString();
            Iservice.editCategorie(id, categorie);

            clearInputAndReloadFrame();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            dataChecker();
            int id = int.Parse(dgvCategorie.CurrentRow.Cells[0].Value.ToString());
            Iservice.removeCategorie(id);
            clearInputAndReloadFrame();
        }

        private void btnSelectItem_Click_1(object sender, EventArgs e)
        {
            tbxCategorie.Text = dgvCategorie.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
