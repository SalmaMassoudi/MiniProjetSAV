using System;

namespace MiniProjetSAV.Models
{
    public class Remplacement
    {
        public int IdRemplacement { get; set; }
        public DateTime DateRemplacement { get; set; }
        public string Raison { get; set; }

        public Retour Retour { get; set; }   // lien vers Retour
    }
}
