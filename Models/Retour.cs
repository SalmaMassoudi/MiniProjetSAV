using System;

namespace MiniProjetSAV.Models
{
    public class Retour
    {
        public int IdRetour { get; set; }
        public DateTime DateRetour { get; set; }
        public string Motif { get; set; }

        public string Statut { get; set; }      // "En attente / En cours / Terminé"
        public string TypeRetour { get; set; }  // "Réparation / Remplacement"

        public Produit Produit { get; set; }
        public Client Client { get; set; }
        public SAV Sav { get; set; }

        public Remplacement Remplacement { get; set; }
        public Reparation Reparation { get; set; }
    }
}
