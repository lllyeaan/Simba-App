using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;
using System.Collections.Generic;

namespace MaterialOrderingApp.Services
{
    public class TruckService
    {
        private readonly TruckRepository _repo;

        public TruckService(TruckRepository repo)
        {
            _repo = repo;
        }

        public List<Truck> GetSemua()
        {
            return _repo.GetAllTrucksWithDriver();
        }

        public List<Truck> GetTersedia()
        {
            return _repo.GetTrukTersedia();
        }
    }
}
