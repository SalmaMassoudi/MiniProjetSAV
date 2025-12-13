using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProjetSAV.Data;
using MiniProjetSAV.Models;

namespace MiniProjetSAV.UI
{
    public partial class TechnicienForm : Form
    {
        private readonly TechnicienRepository _repo = new TechnicienRepository();
        public TechnicienForm()
        {
            InitializeComponent();
            // Optionally configure dgv in code:
            dgvTechniciens.AutoGenerateColumns = false;
            dgvTechniciens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTechniciens.MultiSelect = false;
            // Create columns if you didn't create them in Designer:
            if (dgvTechniciens.Columns.Count == 0)
            {
                dgvTechniciens.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "IdTechnicien",
                    HeaderText = "ID",
                    Width = 60
                });
                dgvTechniciens.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Nom",
                    HeaderText = "Nom",
                    Width = 150
                });
                dgvTechniciens.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Specialite",
                    HeaderText = "Specialite",
                    Width = 150
                });
            }
        }



        private void TechnicienForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _repo.GetAll();
                dgvTechniciens.DataSource = null;
                dgvTechniciens.DataSource = list;
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
            txtSpec.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var t = new Technicien
                {
                    Nom = txtNom.Text.Trim(),
                    Specialite = txtSpec.Text.Trim()
                };
                _repo.Add(t);
                LoadData();
                MessageBox.Show("Technicien ajouté.");
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
                MessageBox.Show("Sélectionnez un technicien à mettre à jour.");
                return;
            }

            try
            {
                var t = new Technicien
                {
                    IdTechnicien = id,
                    Nom = txtNom.Text.Trim(),
                    Specialite = txtSpec.Text.Trim()
                };
                _repo.Update(t);
                LoadData();
                MessageBox.Show("Technicien mis à jour.");
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
                MessageBox.Show("Sélectionnez un technicien à supprimer.");
                return;
            }

            var confirm = MessageBox.Show("Supprimer ce technicien ?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _repo.Delete(id);
                LoadData();
                MessageBox.Show("Technicien supprimé.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur delete: " + ex.Message);
            }
        }
        private void dgvTechniciens_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTechniciens.CurrentRow == null) return;
            if (dgvTechniciens.CurrentRow.DataBoundItem is Technicien t)
            {
                txtId.Text = t.IdTechnicien.ToString();
                txtNom.Text = t.Nom;
                txtSpec.Text = t.Specialite;
            }
        }
    }
}
