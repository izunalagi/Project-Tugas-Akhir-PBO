using System;
using System.Collections.Generic;
using Project_Akhir_PBO.models;

namespace Project_Akhir_PBO.controllers
{
    public class BuyerController
    {
        private BuyerModel _buyerModel;

        public BuyerController()
        {
            _buyerModel = new BuyerModel();
        }

        public void TambahBuyer(string nama, string noTelepon, string alamat)
        {
            try
            {
                _buyerModel.InsertBuyer(nama, noTelepon, alamat);
                Console.WriteLine("Buyer berhasil ditambahkan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan saat menambahkan buyer: {ex.Message}");
            }
        }

        public void HapusBuyer(int id)
        {
            try
            {
                _buyerModel.DeleteBuyer(id);
                Console.WriteLine("Buyer berhasil dihapus.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan saat menghapus buyer: {ex.Message}");
            }
        }

        public void UpdateBuyer(int id, string nama, string noTelepon, string alamat)
        {
            try
            {
                _buyerModel.UpdateBuyer(id, nama, noTelepon, alamat);
                Console.WriteLine("Data pembeli berhasil diperbarui.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan saat memperbarui data pembeli: {ex.Message}");
            }
        }

        public List<Project_Akhir_PBO.models.Buyer> GetAllBuyers()
        {
            return  _buyerModel.GetAllBuyers();
        }
    }
}
