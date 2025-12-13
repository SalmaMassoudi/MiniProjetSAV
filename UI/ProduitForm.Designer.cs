namespace MiniProjetSAV.UI
{
    partial class ProduitForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer generated code
        private void InitializeComponent()
        {
            dgvProduits = new DataGridView();
            panelLeft = new Panel();
            lblId = new Label();
            txtId = new TextBox();
            lblNom = new Label();
            txtNom = new TextBox();
            lblCategorie = new Label();
            txtCategorie = new TextBox();
            lblGarantie = new Label();
            txtGarantie = new TextBox();

            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvProduits).BeginInit();
            panelLeft.SuspendLayout();
            SuspendLayout();

            // -------------------- DATAGRID --------------------
            dgvProduits.AllowUserToAddRows = false;
            dgvProduits.AllowUserToDeleteRows = false;
            dgvProduits.Dock = DockStyle.Fill;
            dgvProduits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduits.MultiSelect = false;
            dgvProduits.ReadOnly = true;
            dgvProduits.SelectionChanged += dgvProduits_SelectionChanged;

            // -------------------- LEFT PANEL --------------------
            panelLeft.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Padding = new Padding(15);
            panelLeft.Size = new System.Drawing.Size(250, 500);
            panelLeft.Controls.Add(lblId);
            panelLeft.Controls.Add(txtId);
            panelLeft.Controls.Add(lblNom);
            panelLeft.Controls.Add(txtNom);
            panelLeft.Controls.Add(lblCategorie);
            panelLeft.Controls.Add(txtCategorie);
            panelLeft.Controls.Add(lblGarantie);
            panelLeft.Controls.Add(txtGarantie);
            panelLeft.Controls.Add(btnAdd);
            panelLeft.Controls.Add(btnUpdate);
            panelLeft.Controls.Add(btnDelete);

            // Labels & TextBoxes
            lblId.Text = "ID Produit"; lblId.Top = 10; lblId.Left = 10;
            txtId.Top = 35; txtId.Left = 10; txtId.Width = 200; txtId.ReadOnly = true;

            lblNom.Text = "Nom"; lblNom.Top = 75; lblNom.Left = 10;
            txtNom.Top = 100; txtNom.Left = 10; txtNom.Width = 200;

            lblCategorie.Text = "Catégorie"; lblCategorie.Top = 140; lblCategorie.Left = 10;
            txtCategorie.Top = 165; txtCategorie.Left = 10; txtCategorie.Width = 200;

            lblGarantie.Text = "Garantie (mois)"; lblGarantie.Top = 205; lblGarantie.Left = 10;
            txtGarantie.Top = 230; txtGarantie.Left = 10; txtGarantie.Width = 200;

            // Buttons
            btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            btnAdd.FlatStyle = FlatStyle.Flat; btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(10, 280); btnAdd.Size = new System.Drawing.Size(200, 34);
            btnAdd.Text = "Ajouter"; btnAdd.Click += btnAdd_Click;

            btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 140, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat; btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(10, 324); btnUpdate.Size = new System.Drawing.Size(95, 34);
            btnUpdate.Text = "Modifier"; btnUpdate.Click += btnUpdate_Click;

            btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnDelete.FlatStyle = FlatStyle.Flat; btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(115, 324); btnDelete.Size = new System.Drawing.Size(95, 34);
            btnDelete.Text = "Supprimer"; btnDelete.Click += btnDelete_Click;

            // Form
            Controls.Add(dgvProduits);
            Controls.Add(panelLeft);
            Text = "Gestion des Produits";
            ClientSize = new System.Drawing.Size(900, 500);
            Load += ProduitForm_Load;

            ((System.ComponentModel.ISupportInitialize)dgvProduits).EndInit();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Label lblId, lblNom, lblCategorie, lblGarantie;
        private TextBox txtId, txtNom, txtCategorie, txtGarantie;
        private DataGridView dgvProduits;
        private Button btnAdd, btnUpdate, btnDelete;
    }
}
