using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MiniProjetSAV.Data;
using MiniProjetSAV.Models;

namespace MiniProjetSAV.UI
{
    public partial class ProduitForm : Form
    {
        private readonly ProduitRepository _repo = new ProduitRepository();

        public ProduitForm()
        {
            InitializeComponent();

            dgvProduits.AutoGenerateColumns = false;
            dgvProduits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduits.MultiSelect = false;

            if (dgvProduits.Columns.Count == 0)
            {
                dgvProduits.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "IdProduit",
                    HeaderText = "ID",
                    Width = 60
                });
                dgvProduits.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Nom",
                    HeaderText = "Nom",
                    Width = 150
                });
                dgvProduits.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Categorie",
                    HeaderText = "Catégorie",
                    Width = 150
                });
                dgvProduits.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "GarantieMois",
                    HeaderText = "Garantie (mois)",
                    Width = 100
                });
            }
        }

        private void ProduitForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _repo.GetAll();
                dgvProduits.DataSource = null;
                dgvProduits.DataSource = list;
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur en chargeant les données: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtCategorie.Text = "";
            txtGarantie.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new Produit
                {
                    Nom = txtNom.Text.Trim(),
                    Categorie = txtCategorie.Text.Trim(),
                    GarantieMois = int.TryParse(txtGarantie.Text, out int gm) ? gm : 0
                };
                _repo.Add(p);
                LoadData();
                MessageBox.Show("Produit ajouté.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur ajout: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Sélectionnez un produit à mettre à jour.");
                return;
            }

            try
            {
                var p = new Produit
                {
                    IdProduit = id,
                    Nom = txtNom.Text.Trim(),
                    Categorie = txtCategorie.Text.Trim(),
                    GarantieMois = int.TryParse(txtGarantie.Text, out int gm) ? gm : 0
                };
                _repo.Update(p);
                LoadData();
                MessageBox.Show("Produit mis à jour.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur update: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Sélectionnez un produit à supprimer.");
                return;
            }

            var confirm = MessageBox.Show("Supprimer ce produit ?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _repo.Delete(id);
                LoadData();
                MessageBox.Show("Produit supprimé.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur delete: " + ex.Message);
            }
        }

        private void dgvProduits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduits.CurrentRow == null) return;
            if (dgvProduits.CurrentRow.DataBoundItem is Produit p)
            {
                txtId.Text = p.IdProduit.ToString();
                txtNom.Text = p.Nom;
                txtCategorie.Text = p.Categorie;
                txtGarantie.Text = p.GarantieMois.ToString();
            }
        }
    }
}
