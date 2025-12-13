using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MiniProjetSAV.Models;

namespace MiniProjetSAV.Data
{
    public class RetourRepository
    {
        public void Add(Retour r)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(
                @"INSERT INTO Retour 
                  (DateRetour, Motif, Statut, TypeRetour, IdProduit, IdClient)
                  VALUES (@DateRetour, @Motif, @Statut, @TypeRetour, @IdProduit, @IdClient)", conn);

            cmd.Parameters.AddWithValue("@DateRetour", r.DateRetour);
            cmd.Parameters.AddWithValue("@Motif", r.Motif ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Statut", r.Statut ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@TypeRetour", r.TypeRetour ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@IdProduit", r.Produit?.IdProduit ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@IdClient", r.Client?.IdClient ?? (object)DBNull.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<Retour> GetAll()
        {
            var list = new List<Retour>();
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(
                @"SELECT r.IdRetour, r.DateRetour, r.Motif, r.Statut, r.TypeRetour,
                         r.IdProduit, p.Nom AS ProduitNom,
                         r.IdClient, c.Nom AS ClientNom
                  FROM Retour r
                  LEFT JOIN Produit p ON r.IdProduit = p.IdProduit
                  LEFT JOIN Client c ON r.IdClient = c.IdClient", conn);

            conn.Open();
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Retour
                {
                    IdRetour = (int)rdr["IdRetour"],
                    DateRetour = (DateTime)rdr["DateRetour"],
                    Motif = rdr["Motif"]?.ToString(),
                    Statut = rdr["Statut"]?.ToString(),
                    TypeRetour = rdr["TypeRetour"]?.ToString(),
                    Produit = new Produit { IdProduit = rdr["IdProduit"] as int? ?? 0, Nom = rdr["ProduitNom"]?.ToString() },
                    Client = new Client { IdClient = rdr["IdClient"] as int? ?? 0, Nom = rdr["ClientNom"]?.ToString() }
                });
            }
            return list;
        }

        public void Update(Retour r)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(
                @"UPDATE Retour SET
                  DateRetour=@DateRetour,
                  Motif=@Motif,
                  Statut=@Statut,
                  TypeRetour=@TypeRetour,
                  IdProduit=@IdProduit,
                  IdClient=@IdClient
                  WHERE IdRetour=@Id", conn);

            cmd.Parameters.AddWithValue("@DateRetour", r.DateRetour);
            cmd.Parameters.AddWithValue("@Motif", r.Motif ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Statut", r.Statut ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@TypeRetour", r.TypeRetour ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@IdProduit", r.Produit?.IdProduit ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@IdClient", r.Client?.IdClient ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Id", r.IdRetour);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM Retour WHERE IdRetour=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
