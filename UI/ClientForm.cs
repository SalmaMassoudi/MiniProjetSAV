using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MiniProjetSAV.Data;
using MiniProjetSAV.Models;

namespace MiniProjetSAV.UI
{
    public partial class ClientForm : Form
    {
        private readonly ClientRepository _repo = new ClientRepository();

        public ClientForm()
        {
            InitializeComponent();

            dgvClients.AutoGenerateColumns = false;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.MultiSelect = false;

            if (dgvClients.Columns.Count == 0)
            {
                dgvClients.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "IdClient",
                    HeaderText = "ID",
                    Width = 60
                });
                dgvClients.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Nom",
                    HeaderText = "Nom",
                    Width = 150
                });
                dgvClients.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Email",
                    HeaderText = "Email",
                    Width = 200
                });
                dgvClients.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Telephone",
                    HeaderText = "Téléphone",
                    Width = 120
                });
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _repo.GetAll();
                dgvClients.DataSource = null;
                dgvClients.DataSource = list;
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
            txtEmail.Text = "";
            txtTel.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var c = new Client
                {
                    Nom = txtNom.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Telephone = txtTel.Text.Trim()
                };
                _repo.Add(c);
                LoadData();
                MessageBox.Show("Client ajouté.");
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
                MessageBox.Show("Sélectionnez un client à mettre à jour.");
                return;
            }

            try
            {
                var c = new Client
                {
                    IdClient = id,
                    Nom = txtNom.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Telephone = txtTel.Text.Trim()
                };
                _repo.Update(c);
                LoadData();
                MessageBox.Show("Client mis à jour.");
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
                MessageBox.Show("Sélectionnez un client à supprimer.");
                return;
            }

            var confirm = MessageBox.Show("Supprimer ce client ?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _repo.Delete(id);
                LoadData();
                MessageBox.Show("Client supprimé.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur delete: " + ex.Message);
            }
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;
            if (dgvClients.CurrentRow.DataBoundItem is Client c)
            {
                txtId.Text = c.IdClient.ToString();
                txtNom.Text = c.Nom;
                txtEmail.Text = c.Email;
                txtTel.Text = c.Telephone;
            }
        }
    }
}
