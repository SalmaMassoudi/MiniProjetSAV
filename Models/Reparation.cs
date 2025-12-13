using System;

namespace MiniProjetSAV.Models
{
    public class Reparation
    {
        public int IdReparation { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Description { get; set; }
        public double Cout { get; set; }

        public Retour Retour { get; set; }
        public Technicien Technicien { get; set; }
    }
}
