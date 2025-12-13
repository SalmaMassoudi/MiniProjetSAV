using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MiniProjetSAV.Data;
using MiniProjetSAV.Models;

namespace MiniProjetSAV.UI
{
    public partial class RetourForm : Form
    {
        private readonly RetourRepository _repo = new RetourRepository();
        private readonly ProduitRepository _produitRepo = new ProduitRepository();
        private readonly ClientRepository _clientRepo = new ClientRepository();

        public RetourForm()
        {
            InitializeComponent();

            dgvRetours.AutoGenerateColumns = false;
            dgvRetours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRetours.MultiSelect = false;

            if (dgvRetours.Columns.Count == 0)
            {
                dgvRetours.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "IdRetour",
                    HeaderText = "ID",
                    Width = 60
                });
                dgvRetours.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "DateRetour",
                    HeaderText = "Date",
                    Width = 100
                });
                dgvRetours.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Motif",
                    HeaderText = "Motif",
                    Width = 200
                });
                dgvRetours.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Statut",
                    HeaderText = "Statut",
                    Width = 100
                });
                dgvRetours.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TypeRetour",
                    HeaderText = "Type",
                    Width = 100
                });
                dgvRetours.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Produit.Nom",
                    HeaderText = "Produit",
                    Width = 150
                });
                dgvRetours.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Client.Nom",
                    HeaderText = "Client",
                    Width = 150
                });
            }
        }

        private void RetourForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxes();
        }

        private void LoadData()
        {
            try
            {
                var list = _repo.GetAll();
                dgvRetours.DataSource = null;
                dgvRetours.DataSource = list;
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur en chargeant les données: " + ex.Message);
            }
        }

        private void LoadComboBoxes()
        {
            cmbProduit.DataSource = _produitRepo.GetAll();
            cmbProduit.DisplayMember = "Nom";
            cmbProduit.ValueMember = "IdProduit";

            cmbClient.DataSource = _clientRepo.GetAll();
            cmbClient.DisplayMember = "Nom";
            cmbClient.ValueMember = "IdClient";
        }

        private void ClearInputs()
        {
            txtId.Text = "";
            txtMotif.Text = "";
            cmbType.SelectedIndex = -1;
            cmbStatut.SelectedIndex = -1;
            cmbProduit.SelectedIndex = -1;
            cmbClient.SelectedIndex = -1;
            dtpDate.Value = DateTime.Today;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var r = new Retour
                {
                    DateRetour = dtpDate.Value,
                    Motif = txtMotif.Text.Trim(),
                    Statut = cmbStatut.SelectedItem?.ToString(),
                    TypeRetour = cmbType.SelectedItem?.ToString(),
                    Produit = cmbProduit.SelectedItem as Produit,
                    Client = cmbClient.SelectedItem as Client
                };
                _repo.Add(r);
                LoadData();
                MessageBox.Show("Retour ajouté.");
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
                MessageBox.Show("Sélectionnez un retour à mettre à jour.");
                return;
            }

            try
            {
                var r = new Retour
                {
                    IdRetour = id,
                    DateRetour = dtpDate.Value,
                    Motif = txtMotif.Text.Trim(),
                    Statut = cmbStatut.SelectedItem?.ToString(),
                    TypeRetour = cmbType.SelectedItem?.ToString(),
                    Produit = cmbProduit.SelectedItem as Produit,
                    Client = cmbClient.SelectedItem as Client
                };
                _repo.Update(r);
                LoadData();
                MessageBox.Show("Retour mis à jour.");
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
                MessageBox.Show("Sélectionnez un retour à supprimer.");
                return;
            }

            var confirm = MessageBox.Show("Supprimer ce retour ?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _repo.Delete(id);
                LoadData();
                MessageBox.Show("Retour supprimé.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur delete: " + ex.Message);
            }
        }

        private void dgvRetours_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRetours.CurrentRow == null) return;
            if (dgvRetours.CurrentRow.DataBoundItem is Retour r)
            {
                txtId.Text = r.IdRetour.ToString();
                txtMotif.Text = r.Motif;
                dtpDate.Value = r.DateRetour;
                cmbStatut.SelectedItem = r.Statut;
                cmbType.SelectedItem = r.TypeRetour;
                cmbProduit.SelectedItem = r.Produit;
                cmbClient.SelectedItem = r.Client;
            }
        }
    }
}
