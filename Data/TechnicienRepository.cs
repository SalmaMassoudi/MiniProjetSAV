using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MiniProjetSAV.Models;

namespace MiniProjetSAV.Data
{
    public class TechnicienRepository
    {
        public void Add(Technicien t)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(
                "INSERT INTO Technicien (Nom, Specialite) VALUES (@Nom, @Specialite)", conn);
            cmd.Parameters.AddWithValue("@Nom", t.Nom ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Specialite", t.Specialite ?? (object)DBNull.Value);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<Technicien> GetAll()
        {
            var list = new List<Technicien>();
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("SELECT IdTechnicien, Nom, Specialite FROM Technicien", conn);
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Technicien
                {
                    IdTechnicien = (int)rdr["IdTechnicien"],
                    Nom = rdr["Nom"]?.ToString(),
                    Specialite = rdr["Specialite"]?.ToString()
                });
            }
            return list;
        }

        public void Update(Technicien t)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(
                "UPDATE Technicien SET Nom=@Nom, Specialite=@Specialite WHERE IdTechnicien=@Id", conn);
            cmd.Parameters.AddWithValue("@Nom", t.Nom ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Specialite", t.Specialite ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Id", t.IdTechnicien);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM Technicien WHERE IdTechnicien=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
