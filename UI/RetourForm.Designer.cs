namespace MiniProjetSAV.UI
{
    partial class RetourForm
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
            dgvRetours = new DataGridView();
            panelLeft = new Panel();
            tableLayout = new TableLayoutPanel();

            lblId = new Label(); txtId = new TextBox();
            lblDate = new Label(); dtpDate = new DateTimePicker();
            lblMotif = new Label(); txtMotif = new TextBox();
            lblStatut = new Label(); cmbStatut = new ComboBox();
            lblType = new Label(); cmbType = new ComboBox();
            lblProduit = new Label(); cmbProduit = new ComboBox();
            lblClient = new Label(); cmbClient = new ComboBox();

            btnAdd = new Button(); btnUpdate = new Button(); btnDelete = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvRetours).BeginInit();
            panelLeft.SuspendLayout();
            tableLayout.SuspendLayout();
            SuspendLayout();

            // ----------- DATAGRID -----------
            dgvRetours.AllowUserToAddRows = false;
            dgvRetours.AllowUserToDeleteRows = false;
            dgvRetours.Dock = DockStyle.Fill;
            dgvRetours.MultiSelect = false;
            dgvRetours.ReadOnly = true;
            dgvRetours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRetours.SelectionChanged += dgvRetours_SelectionChanged;

            // ----------- LEFT PANEL -----------
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Width = 300;
            panelLeft.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            // ----------- TABLELAYOUT -----------
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.ColumnCount = 2;
            tableLayout.RowCount = 9;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F)); // buttons row

            // ----------- ADD LABELS & CONTROLS -----------
            lblId.Text = "ID Retour"; txtId.ReadOnly = true;
            lblDate.Text = "Date Retour";
            lblMotif.Text = "Motif";
            lblStatut.Text = "Statut"; cmbStatut.Items.AddRange(new string[] { "En attente", "En cours", "Terminé" });
            lblType.Text = "Type"; cmbType.Items.AddRange(new string[] { "Réparation", "Remplacement" });
            lblProduit.Text = "Produit";
            lblClient.Text = "Client";

            tableLayout.Controls.Add(lblId, 0, 0);
            tableLayout.Controls.Add(txtId, 1, 0);
            tableLayout.Controls.Add(lblDate, 0, 1);
            tableLayout.Controls.Add(dtpDate, 1, 1);
            tableLayout.Controls.Add(lblMotif, 0, 2);
            tableLayout.Controls.Add(txtMotif, 1, 2);
            tableLayout.Controls.Add(lblStatut, 0, 3);
            tableLayout.Controls.Add(cmbStatut, 1, 3);
            tableLayout.Controls.Add(lblType, 0, 4);
            tableLayout.Controls.Add(cmbType, 1, 4);
            tableLayout.Controls.Add(lblProduit, 0, 5);
            tableLayout.Controls.Add(cmbProduit, 1, 5);
            tableLayout.Controls.Add(lblClient, 0, 6);
            tableLayout.Controls.Add(cmbClient, 1, 6);

            // ----------- BUTTONS -----------
            FlowLayoutPanel buttonPanel = new FlowLayoutPanel();
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.FlowDirection = FlowDirection.LeftToRight;

            btnAdd.Text = "Ajouter"; btnAdd.Width = 250; btnAdd.Height = 34;
            btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            btnAdd.FlatStyle = FlatStyle.Flat; btnAdd.FlatAppearance.BorderSize = 0; btnAdd.ForeColor = Color.White;
            btnAdd.Click += btnAdd_Click;

            btnUpdate.Text = "Modifier"; btnUpdate.Width = 120; btnUpdate.Height = 34;
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 140, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat; btnUpdate.FlatAppearance.BorderSize = 0; btnUpdate.ForeColor = Color.White;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Text = "Supprimer"; btnDelete.Width = 120; btnDelete.Height = 34;
            btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnDelete.FlatStyle = FlatStyle.Flat; btnDelete.FlatAppearance.BorderSize = 0; btnDelete.ForeColor = Color.White;
            btnDelete.Click += btnDelete_Click;

            buttonPanel.Controls.Add(btnAdd);
            buttonPanel.Controls.Add(btnUpdate);
            buttonPanel.Controls.Add(btnDelete);

            tableLayout.Controls.Add(buttonPanel, 0, 8);
            tableLayout.SetColumnSpan(buttonPanel, 2);

            panelLeft.Controls.Add(tableLayout);

            // ----------- FORM -----------
            Controls.Add(dgvRetours);
            Controls.Add(panelLeft);
            Text = "Gestion des Retours";
            ClientSize = new System.Drawing.Size(1000, 500);
            Load += RetourForm_Load;

            ((System.ComponentModel.ISupportInitialize)dgvRetours).EndInit();
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Panel panelLeft;
        private TableLayoutPanel tableLayout;
        private Label lblId, lblDate, lblMotif, lblStatut, lblType, lblProduit, lblClient;
        private TextBox txtId, txtMotif;
        private DateTimePicker dtpDate;
        private ComboBox cmbStatut, cmbType, cmbProduit, cmbClient;
        private DataGridView dgvRetours;
        private Button btnAdd, btnUpdate, btnDelete;
    }
}
