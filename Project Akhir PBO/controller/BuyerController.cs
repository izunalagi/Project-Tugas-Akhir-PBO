using System.Collections.Generic;

namespace ProjectAkhirPBO.Controllers
{
    public class BuyerController
    {
        private List<Buyer> buyers;

        public BuyerController()
        {
            buyers = new List<Buyer>();
        }

        public List<Buyer> GetAllBuyers()
        {
            return buyers;
        }

        public void AddBuyer(Buyer buyer)
        {
            buyers.Add(buyer);
        }

        public void UpdateBuyer(Buyer buyer)
        {
            var existingBuyer = buyers.Find(b => b.Id_Buyer == buyer.Id_Buyer);
            if (existingBuyer != null)
            {
                existingBuyer.Nama = buyer.Nama;
                existingBuyer.No_Telepon = buyer.No_Telepon;
                existingBuyer.Alamat = buyer.Alamat;
            }
        }

        public void DeleteBuyer(int id)
        {
            var buyer = buyers.Find(b => b.Id_Buyer == id);
            if (buyer != null)
            {
                buyers.Remove(buyer);
            }
        }
    }
}
