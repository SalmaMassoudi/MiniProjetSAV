using MiniProjetSAV.UI;

namespace MiniProjetSAV;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnTechniciens = new Button();
        btnClients = new Button();
        btnProduits = new Button();
        btnRetours = new Button();
        SuspendLayout();
        // 
        // btnTechniciens
        // 
        btnTechniciens.BackColor = Color.FromArgb(0, 122, 204);
        btnTechniciens.FlatAppearance.BorderSize = 0;
        btnTechniciens.FlatStyle = FlatStyle.Flat;
        btnTechniciens.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnTechniciens.ForeColor = Color.White;
        btnTechniciens.Location = new Point(100, 49);
        btnTechniciens.Name = "btnTechniciens";
        btnTechniciens.Size = new Size(200, 40);
        btnTechniciens.TabIndex = 0;
        btnTechniciens.Text = "Gestion des Techniciens";
        btnTechniciens.UseVisualStyleBackColor = false;
        // 
        // btnClients
        // 
        btnClients.BackColor = Color.FromArgb(0, 122, 204);
        btnClients.FlatAppearance.BorderSize = 0;
        btnClients.FlatStyle = FlatStyle.Flat;
        btnClients.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnClients.ForeColor = Color.White;
        btnClients.Location = new Point(100, 99);
        btnClients.Name = "btnClients";
        btnClients.Size = new Size(200, 40);
        btnClients.TabIndex = 1;
        btnClients.Text = "Gestion des Clients";
        btnClients.UseVisualStyleBackColor = false;
        // 
        // btnProduits
        // 
        btnProduits.BackColor = Color.FromArgb(0, 122, 204);
        btnProduits.FlatAppearance.BorderSize = 0;
        btnProduits.FlatStyle = FlatStyle.Flat;
        btnProduits.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnProduits.ForeColor = Color.White;
        btnProduits.Location = new Point(100, 149);
        btnProduits.Name = "btnProduits";
        btnProduits.Size = new Size(200, 40);
        btnProduits.TabIndex = 2;
        btnProduits.Text = "Gestion des Produits";
        btnProduits.UseVisualStyleBackColor = false;
        // 
        // btnRetours
        // 
        btnRetours.BackColor = Color.FromArgb(0, 122, 204);
        btnRetours.FlatAppearance.BorderSize = 0;
        btnRetours.FlatStyle = FlatStyle.Flat;
        btnRetours.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnRetours.ForeColor = Color.White;
        btnRetours.Location = new Point(100, 199);
        btnRetours.Name = "btnRetours";
        btnRetours.Size = new Size(200, 40);
        btnRetours.TabIndex = 3;
        btnRetours.Text = "Gestion des Retours";
        btnRetours.UseVisualStyleBackColor = false;
        // 
        // MainForm
        // 
        ClientSize = new Size(400, 300);
        Controls.Add(btnTechniciens);
        Controls.Add(btnClients);
        Controls.Add(btnProduits);
        Controls.Add(btnRetours);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "MiniProjet SAV - Dashboard";
        ResumeLayout(false);
    }



    #endregion
}
