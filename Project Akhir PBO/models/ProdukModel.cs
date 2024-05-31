using Npgsql;
using System;
using System.Collections.Generic;

namespace Project_Akhir_PBO.models
{
    public class ProdukModel
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=Atharbro2004;Database=pbo_project";

        public void InsertProduk(string Nama_Produk, int Stock, int Ukuran_Kain, decimal Harga)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO Produk (Nama_Produk, Stock, Ukuran_Kain, Harga) VALUES (@Nama_Produk, @Stock, @Ukuran_Kain, @Harga)", conn);
                cmd.Parameters.AddWithValue("Nama_Produk", Nama_Produk);  
                cmd.Parameters.AddWithValue("Stock", Stock);  
                cmd.Parameters.AddWithValue("Ukuran_Kain", Ukuran_Kain); 
                cmd.Parameters.AddWithValue("Harga", Harga);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<Produk> GetAllProduks()
        {
            var produks = new List<Produk>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM Produk", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produks.Add(new Produk
                        {
                            Id = reader.GetInt32(0),
                            Nama_Produk = reader.GetString(1),
                            Stock = reader.GetInt32(2),
                            Ukuran_Kain = reader.GetInt32(3),  
                            Harga = reader.GetDecimal(4),
                        });
                    }
                }
            }
            return produks;
        }
    }

    public class Produk
    {
        public int Id { get; set; }
        public string Nama_Produk { get; set; }
        public int Stock { get; set; }  
        public int Ukuran_Kain { get; set; }  
        public decimal Harga { get; set; }  
    }
}
