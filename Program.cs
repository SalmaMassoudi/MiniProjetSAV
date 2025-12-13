using System;
using System.Windows.Forms;

namespace MiniProjetSAV
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lancement de l’interface
            Application.Run(new MainForm());
        }
    }
}
