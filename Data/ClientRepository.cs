using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MiniProjetSAV.Models;

namespace MiniProjetSAV.Data
{
    public class ClientRepository
    {
        public void Add(Client c)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(
                "INSERT INTO Client (Nom, Email, Telephone) VALUES (@Nom, @Email, @Telephone)", conn);

            cmd.Parameters.AddWithValue("@Nom", c.Nom ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", c.Email ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Telephone", c.Telephone ?? (object)DBNull.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<Client> GetAll()
        {
            var list = new List<Client>();

            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("SELECT IdClient, Nom, Email, Telephone FROM Client", conn);

            conn.Open();
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Client
                {
                    IdClient = (int)rdr["IdClient"],
                    Nom = rdr["Nom"]?.ToString(),
                    Email = rdr["Email"]?.ToString(),
                    Telephone = rdr["Telephone"]?.ToString()
                });
            }

            return list;
        }

        public void Update(Client c)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand(
                "UPDATE Client SET Nom=@Nom, Email=@Email, Telephone=@Telephone WHERE IdClient=@Id", conn);

            cmd.Parameters.AddWithValue("@Nom", c.Nom ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", c.Email ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Telephone", c.Telephone ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Id", c.IdClient);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = Database.GetConnection();
            using var cmd = new SqlCommand("DELETE FROM Client WHERE IdClient=@Id", conn);

            cmd.Parameters.AddWithValue("@Id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
