namespace MiniProjetSAV.UI
{
    partial class ClientForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvClients = new DataGridView();
            panelLeft = new Panel();
            lblId = new Label();
            txtId = new TextBox();
            lblNom = new Label();
            txtNom = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTel = new Label();
            txtTel = new TextBox();

            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            panelLeft.SuspendLayout();
            SuspendLayout();

            // -------------------- DATAGRID --------------------
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.Dock = DockStyle.Fill;
            dgvClients.Location = new System.Drawing.Point(250, 0);
            dgvClients.MultiSelect = false;
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new System.Drawing.Size(650, 500);
            dgvClients.TabIndex = 0;
            dgvClients.SelectionChanged += dgvClients_SelectionChanged;

            // -------------------- LEFT PANEL --------------------
            panelLeft.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            panelLeft.Controls.Add(lblId);
            panelLeft.Controls.Add(txtId);
            panelLeft.Controls.Add(lblNom);
            panelLeft.Controls.Add(txtNom);
            panelLeft.Controls.Add(lblEmail);
            panelLeft.Controls.Add(txtEmail);
            panelLeft.Controls.Add(lblTel);
            panelLeft.Controls.Add(txtTel);
            panelLeft.Controls.Add(btnAdd);
            panelLeft.Controls.Add(btnUpdate);
            panelLeft.Controls.Add(btnDelete);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new System.Drawing.Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(15);
            panelLeft.Size = new System.Drawing.Size(250, 500);
            panelLeft.TabIndex = 1;

            // -------------------- LABELS & TEXTBOXES --------------------
            lblId.AutoSize = true;
            lblId.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblId.Location = new System.Drawing.Point(10, 10);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(62, 19);
            lblId.Text = "ID Client";

            txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtId.Location = new System.Drawing.Point(10, 35);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new System.Drawing.Size(200, 25);

            lblNom.AutoSize = true;
            lblNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblNom.Location = new System.Drawing.Point(10, 75);
            lblNom.Text = "Nom";

            txtNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNom.Location = new System.Drawing.Point(10, 100);
            txtNom.Size = new System.Drawing.Size(200, 25);

            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblEmail.Location = new System.Drawing.Point(10, 140);
            lblEmail.Text = "Email";

            txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtEmail.Location = new System.Drawing.Point(10, 165);
            txtEmail.Size = new System.Drawing.Size(200, 25);

            lblTel.AutoSize = true;
            lblTel.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblTel.Location = new System.Drawing.Point(10, 205);
            lblTel.Text = "Téléphone";

            txtTel.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtTel.Location = new System.Drawing.Point(10, 230);
            txtTel.Size = new System.Drawing.Size(200, 25);

            // -------------------- BUTTONS --------------------
            btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(10, 280);
            btnAdd.Size = new System.Drawing.Size(200, 34);
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 140, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(10, 324);
            btnUpdate.Size = new System.Drawing.Size(95, 34);
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(115, 324);
            btnDelete.Size = new System.Drawing.Size(95, 34);
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            // -------------------- FORM --------------------
            Controls.Add(dgvClients);
            Controls.Add(panelLeft);
            Text = "Gestion des Clients";
            ClientSize = new System.Drawing.Size(900, 500);
            Load += ClientForm_Load;

            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Label lblId, lblNom, lblEmail, lblTel;
        private TextBox txtId, txtNom, txtEmail, txtTel;
        private DataGridView dgvClients;
        private Button btnAdd, btnUpdate, btnDelete;
    }
}
