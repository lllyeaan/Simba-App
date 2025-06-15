using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialOrderingApp.Models;
using MaterialOrderingApp.Repositories;

namespace MaterialOrderingApp.Services
{
    public class MaterialService
    {
        private readonly MaterialRepository _repo;

        public MaterialService(MaterialRepository repo)
        {
            _repo = repo;
        }

        public List<Material> AmbilSemua()
        {
            return _repo.GetAll();
        }

        public void TambahMaterial(Material material)
        {
            _repo.Insert(material);
        }

        public void Update(Material material)
        {
            _repo.Update(material);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }

}
