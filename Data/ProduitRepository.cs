using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MiniProjetSAV.Models;

namespace MiniProjetSAV.Data
{
    public class ProduitRepository
    {
        public void Add(Produit p)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(
                "INSERT INTO Produit (Nom, Categorie, GarantieMois) VALUES (@Nom, @Categorie, @GarantieMois)", conn);

            cmd.Parameters.AddWithValue("@Nom", p.Nom ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Categorie", p.Categorie ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@GarantieMois", p.GarantieMois);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<Produit> GetAll()
        {
            var list = new List<Produit>();
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("SELECT IdProduit, Nom, Categorie, GarantieMois FROM Produit", conn);

            conn.Open();
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Produit
                {
                    IdProduit = (int)rdr["IdProduit"],
                    Nom = rdr["Nom"]?.ToString(),
                    Categorie = rdr["Categorie"]?.ToString(),
                    GarantieMois = (int)rdr["GarantieMois"]
                });
            }
            return list;
        }

        public void Update(Produit p)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(
                "UPDATE Produit SET Nom=@Nom, Categorie=@Categorie, GarantieMois=@GarantieMois WHERE IdProduit=@Id", conn);

            cmd.Parameters.AddWithValue("@Nom", p.Nom ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Categorie", p.Categorie ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@GarantieMois", p.GarantieMois);
            cmd.Parameters.AddWithValue("@Id", p.IdProduit);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM Produit WHERE IdProduit=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
