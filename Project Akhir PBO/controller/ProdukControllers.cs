using Project_Akhir_PBO.models;
using System;

namespace Project_Akhir_PBO.controller
{
    public class ProdukControllers
    {
        private ProdukModel _produkModel;

        public ProdukControllers()
        {
            _produkModel = new ProdukModel();
        }

        public void TambahProduk(string nama_produk, int stock_produk, int size_produk, decimal harga)
        {
            try
            {
                _produkModel.InsertProduk(nama_produk, stock_produk, size_produk, harga);
                Console.WriteLine("Produk berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan saat menambahkan Produk: {ex.Message}");
            }
        }
    }
}

