using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;

namespace MaterialOrderingApp.Services
{
    public class OrderService
    {
        private readonly DeliveryRepository _deliveryRepo;

        public OrderService(DeliveryRepository deliveryRepo)
        {
            _deliveryRepo = deliveryRepo;
        }

        public List<Delivery> AmbilSemuaPesanan()
        {
            return _deliveryRepo.GetAllDeliveries();
        }

        public void KonfirmasiPengiriman(int idOrder, int idTruck)
        {
            _deliveryRepo.KonfirmasiPengiriman(idOrder, idTruck);
        }

        public List<Order> AmbilPesananByCustomer(int idCustomer)
        {
            return _deliveryRepo.GetByCustomer(idCustomer);
        }
    }
}

