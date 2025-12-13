using MiniProjetSAV.UI;

namespace MiniProjetSAV;

public partial class MainForm : Form
{
    private Button btnTechniciens;
    private Button btnClients;
    private Button btnProduits;
    private Button btnRetours;
    public MainForm()
    {
        InitializeComponent();
        btnTechniciens.Click += BtnTechniciens_Click;
        btnClients.Click += BtnClients_Click;
        btnProduits.Click += BtnProduits_Click;
        btnRetours.Click += BtnRetours_Click;
    }

    private void BtnTechniciens_Click(object sender, EventArgs e)
    {
        new TechnicienForm().ShowDialog();
    }

    private void BtnClients_Click(object sender, EventArgs e)
    {
        new ClientForm().ShowDialog();
    }

    private void BtnProduits_Click(object sender, EventArgs e)
    {
        new ProduitForm().ShowDialog();
    }

    private void BtnRetours_Click(object sender, EventArgs e)
    {
        new RetourForm().ShowDialog();
    }

}
