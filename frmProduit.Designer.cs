
namespace ExamDoNet
{
    partial class frmProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPrixUnitaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCategorie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxQuantite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDenomination = new System.Windows.Forms.TextBox();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.tbxSearchDenomi = new System.Windows.Forms.TextBox();
            this.tbxSearchQt = new System.Windows.Forms.TextBox();
            this.tbxPU = new System.Windows.Forms.TextBox();
            this.tbxSearchCategorie = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prix Unitaire";
            // 
            // tbxPrixUnitaire
            // 
            this.tbxPrixUnitaire.Location = new System.Drawing.Point(50, 359);
            this.tbxPrixUnitaire.Name = "tbxPrixUnitaire";
            this.tbxPrixUnitaire.Size = new System.Drawing.Size(241, 20);
            this.tbxPrixUnitaire.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Categorie";
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Location = new System.Drawing.Point(50, 291);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(241, 21);
            this.cbxCategorie.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantite";
            // 
            // tbxQuantite
            // 
            this.tbxQuantite.Location = new System.Drawing.Point(50, 233);
            this.tbxQuantite.Name = "tbxQuantite";
            this.tbxQuantite.Size = new System.Drawing.Size(241, 20);
            this.tbxQuantite.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Demomination";
            // 
            // tbxDenomination
            // 
            this.tbxDenomination.Location = new System.Drawing.Point(50, 163);
            this.tbxDenomination.Name = "tbxDenomination";
            this.tbxDenomination.Size = new System.Drawing.Size(241, 20);
            this.tbxDenomination.TabIndex = 9;
            // 
            // dgvProduit
            // 
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Location = new System.Drawing.Point(327, 128);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.Size = new System.Drawing.Size(537, 330);
            this.dgvProduit.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 506);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 43);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(257, 506);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 43);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(476, 506);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(136, 43);
            this.BtnDelete.TabIndex = 20;
            this.BtnDelete.Text = "Supprimer";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Location = new System.Drawing.Point(683, 506);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(136, 43);
            this.btnSelectItem.TabIndex = 21;
            this.btnSelectItem.Text = "Selectionner";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // tbxSearchDenomi
            // 
            this.tbxSearchDenomi.Location = new System.Drawing.Point(50, 95);
            this.tbxSearchDenomi.Name = "tbxSearchDenomi";
            this.tbxSearchDenomi.Size = new System.Drawing.Size(124, 20);
            this.tbxSearchDenomi.TabIndex = 22;
            // 
            // tbxSearchQt
            // 
            this.tbxSearchQt.Location = new System.Drawing.Point(207, 95);
            this.tbxSearchQt.Name = "tbxSearchQt";
            this.tbxSearchQt.Size = new System.Drawing.Size(124, 20);
            this.tbxSearchQt.TabIndex = 23;
            // 
            // tbxPU
            // 
            this.tbxPU.Location = new System.Drawing.Point(366, 95);
            this.tbxPU.Name = "tbxPU";
            this.tbxPU.Size = new System.Drawing.Size(124, 20);
            this.tbxPU.TabIndex = 24;
            // 
            // tbxSearchCategorie
            // 
            this.tbxSearchCategorie.Location = new System.Drawing.Point(532, 95);
            this.tbxSearchCategorie.Name = "tbxSearchCategorie";
            this.tbxSearchCategorie.Size = new System.Drawing.Size(124, 20);
            this.tbxSearchCategorie.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(701, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 32);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Demomination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Quantite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Categorie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Prix Unitaire";
            // 
            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 584);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearchCategorie);
            this.Controls.Add(this.tbxPU);
            this.Controls.Add(this.tbxSearchQt);
            this.Controls.Add(this.tbxSearchDenomi);
            this.Controls.Add(this.btnSelectItem);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPrixUnitaire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxQuantite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDenomination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmProduit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPrixUnitaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxQuantite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDenomination;
        private System.Windows.Forms.DataGridView dgvProduit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.TextBox tbxSearchDenomi;
        private System.Windows.Forms.TextBox tbxSearchQt;
        private System.Windows.Forms.TextBox tbxPU;
        private System.Windows.Forms.TextBox tbxSearchCategorie;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}