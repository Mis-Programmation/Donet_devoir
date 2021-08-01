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
    public partial class frmProduit : Form
    {
        private IService Iservice;

        public frmProduit()
        {
            InitializeComponent();
            Iservice = new ServiceImp();
            dgvProduit.DataSource = Iservice.findAllProduit();
            dgvProduit.Columns.Clear();
            this.initCombobox();
        }


        private void initCombobox()
        {
            var categories = Iservice.findAllCategories();
            foreach (var categorie in categories)
            {
                cbxCategorie.Items.Add(categorie);
                cbxCategorie.DisplayMember = "nomCat";
            }

        }

        /// <summary>
        /// Permet d'ajouter un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // produit remplit
           produit produit =  getProduit();
           Iservice.addProduct(produit);
            // vide les champs 
            this.clearInputAndReloadFrame();

        }

        /// <summary>
        /// permet de recuperer les valeurs qui sont dans les input
        /// </summary>
        /// <returns></returns>
        private produit getProduit()
        {
            this.dataChecker();

            produit produit = new produit();
            categorie categorie = (categorie)cbxCategorie.SelectedItem;
            produit.denominationProduit = tbxDenomination.Text.Trim();
            produit.PUProduit = int.Parse(tbxPrixUnitaire.Text.Trim());
            produit.quantiteProduit = int.Parse(tbxQuantite.Text.Trim());
            produit.categorieProduit = categorie.idCat;

            return produit;
        
        }

        /// <summary>
        /// Permet de modifier un projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvProduit.CurrentRow.Cells[0].Value.ToString());
            produit produit = new produit();
            categorie categorie = (categorie)cbxCategorie.SelectedItem;
            produit.denominationProduit = tbxDenomination.Text.Trim();
            produit.PUProduit = int.Parse(tbxPrixUnitaire.Text.Trim());
            produit.quantiteProduit = int.Parse(tbxQuantite.Text.Trim());
            produit.categorieProduit = categorie.idCat;
            Iservice.editProduct(id, produit);
            clearInputAndReloadFrame();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.dataChecker();
            int id = int.Parse(dgvProduit.CurrentRow.Cells[0].Value.ToString());
            Iservice.deleteProduct(id);
        }


        /// <summary>
        /// permet de faire la validation
        /// </summary>
        private void dataChecker()
        {
            if (tbxDenomination.Text.Trim().Equals("")
                || tbxPrixUnitaire.Text.Trim().Equals("")
                || tbxQuantite.Text.Trim().Equals("")
                || cbxCategorie.SelectedIndex == -1
                )
            {
                MessageBox.Show("Tous les champs doivent etre remplit merci ");
                return;
            }

            try
            {
                int.Parse(tbxQuantite.Text);
                float.Parse(tbxPrixUnitaire.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Tous les champs doivent etre remplit merci ");
                return;
            }
        }


        /// <summary>
        /// permet de d'effacer les inputs
        /// </summary>
        private void clearInputAndReloadFrame()
        {
            tbxDenomination.Text = String.Empty;
            tbxPrixUnitaire.Text = String.Empty;
            tbxQuantite.Text = String.Empty;
            cbxCategorie.SelectedIndex = -1;

            dgvProduit.DataSource = Iservice.findAllProduit();
        }

        /// <summary>
        /// permet de sectionnez un element dans le tableau 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectItem_Click(object sender, EventArgs e)
        {

            tbxDenomination.Text = dgvProduit.CurrentRow.Cells[1].Value.ToString();
            tbxPrixUnitaire.Text = dgvProduit.CurrentRow.Cells[3].Value.ToString();
            tbxQuantite.Text = dgvProduit.CurrentRow.Cells[4].Value.ToString();
            cbxCategorie.SelectedItem = (categorie) dgvProduit.CurrentRow.Cells[5].Value;
            cbxCategorie.DisplayMember = "nomCat";

        }


        /// <summary>
        /// permet de valider des inputs type numerique
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int? digitValidator(string value)
        {
            if (!value.Equals(""))
            {
                try
                {
                    return int.Parse(value);
                }
                catch (Exception)
                {
                    MessageBox.Show("Le champs doit etre numerique");
                }
            }
            return null;
        }

        /// <summary>
        /// Permet de faire la recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string denomination = tbxSearchDenomi.Text.Trim();
            int? prixUnitaire =  digitValidator(tbxPU.Text.Trim());
            int? quantite =  digitValidator(tbxSearchQt.Text.Trim());
            string categorie = tbxSearchCategorie.Text.Trim();

        
            if (denomination.Equals("") && prixUnitaire == null && quantite == null && categorie == null) return;

         
            var produits = Iservice.search(denomination,categorie,prixUnitaire,quantite);

            MessageBox.Show(produits.First().denominationProduit);
            if (produits == null)
            {
                MessageBox.Show("Le produit n'existe pas");
            }
            else
            {
                dgvProduit.DataSource = produits;
            }
        }
    }
    }
