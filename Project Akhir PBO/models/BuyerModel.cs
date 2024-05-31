using Npgsql;
using System.Collections.Generic;
using Project_Akhir_PBO.controllers;

namespace Project_Akhir_PBO.models
{
    public class BuyerModel
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=Atharbro2004;Database=pbo_project";

        public List<Buyer> GetAllBuyers()
        {
            var buyers = new List<Buyer>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM Buyer", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        buyers.Add(new Buyer
                        {
                            Id = reader.GetInt32(0),
                            Nama = reader.GetString(1),
                            NoTelepon = reader.GetString(2),
                            Alamat = reader.GetString(3)
                        });
                    }
                }
            }
            return buyers;
        }

        public void InsertBuyer(string nama, string noTelepon, string alamat)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO Buyer (Nama, No_Telepon, Alamat) VALUES (@nama, @noTelepon, @alamat)", conn);
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("noTelepon", noTelepon);
                cmd.Parameters.AddWithValue("alamat", alamat);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateBuyer(int id, string nama, string noTelepon, string alamat)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE Buyer SET Nama = @nama, No_Telepon = @noTelepon, Alamat = @alamat WHERE id_Buyer = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("noTelepon", noTelepon);
                cmd.Parameters.AddWithValue("alamat", alamat);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteBuyer(int id)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM Buyer WHERE id_Buyer = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public class Buyer
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string NoTelepon { get; set; }
        public string Alamat { get; set; }
    }
}
