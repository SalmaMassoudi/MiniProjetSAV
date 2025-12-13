namespace MiniProjetSAV.UI
{
    partial class TechnicienForm
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
            dgvTechniciens = new DataGridView();
            panelLeft = new Panel();
            labelId = new Label();
            txtId = new TextBox();
            labelNom = new Label();
            txtNom = new TextBox();
            labelSpec = new Label();
            txtSpec = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTechniciens).BeginInit();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTechniciens
            // 
            dgvTechniciens.AllowUserToAddRows = false;
            dgvTechniciens.AllowUserToDeleteRows = false;
            dgvTechniciens.Dock = DockStyle.Fill;
            dgvTechniciens.Location = new Point(250, 0);
            dgvTechniciens.MultiSelect = false;
            dgvTechniciens.Name = "dgvTechniciens";
            dgvTechniciens.ReadOnly = true;
            dgvTechniciens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTechniciens.Size = new Size(550, 450);
            dgvTechniciens.TabIndex = 0;
            dgvTechniciens.SelectionChanged += dgvTechniciens_SelectionChanged;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(245, 245, 245);
            panelLeft.Controls.Add(labelId);
            panelLeft.Controls.Add(txtId);
            panelLeft.Controls.Add(labelNom);
            panelLeft.Controls.Add(txtNom);
            panelLeft.Controls.Add(labelSpec);
            panelLeft.Controls.Add(txtSpec);
            panelLeft.Controls.Add(btnAdd);
            panelLeft.Controls.Add(btnUpdate);
            panelLeft.Controls.Add(btnDelete);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(15);
            panelLeft.Size = new Size(250, 450);
            panelLeft.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 10F);
            labelId.Location = new Point(10, 10);
            labelId.Name = "labelId";
            labelId.Size = new Size(89, 19);
            labelId.TabIndex = 0;
            labelId.Text = "ID Technicien";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(10, 35);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 25);
            txtId.TabIndex = 1;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Segoe UI", 10F);
            labelNom.Location = new Point(10, 75);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(39, 19);
            labelNom.TabIndex = 2;
            labelNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Segoe UI", 10F);
            txtNom.Location = new Point(10, 100);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(200, 25);
            txtNom.TabIndex = 3;
            // 
            // labelSpec
            // 
            labelSpec.AutoSize = true;
            labelSpec.Font = new Font("Segoe UI", 10F);
            labelSpec.Location = new Point(10, 145);
            labelSpec.Name = "labelSpec";
            labelSpec.Size = new Size(65, 19);
            labelSpec.TabIndex = 4;
            labelSpec.Text = "Spécialité";
            // 
            // txtSpec
            // 
            txtSpec.Font = new Font("Segoe UI", 10F);
            txtSpec.Location = new Point(10, 170);
            txtSpec.Name = "txtSpec";
            txtSpec.Size = new Size(200, 25);
            txtSpec.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 122, 204);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(10, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 140, 0);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(10, 264);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 34);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Modifier";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(111, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // TechnicienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTechniciens);
            Controls.Add(panelLeft);
            Name = "TechnicienForm";
            Text = "Gestion des Techniciens";
            Load += TechnicienForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTechniciens).EndInit();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelLeft;
        private Label labelId;
        private Label labelNom;
        private Label labelSpec;
        private DataGridView dgvTechniciens;
        private TextBox txtId;
        private TextBox txtNom;
        private TextBox txtSpec;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}