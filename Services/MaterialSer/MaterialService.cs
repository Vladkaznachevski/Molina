using Data;
using Repository.MaterialRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MaterialSer
{
    public class MaterialService : IMaterialService
    {

        private IMaterialRepository _repository;

        public MaterialService(IMaterialRepository repository)
        {
            _repository = repository;
        }


        public List<Material> GetMaterials()
        {
            return _repository.GetAll();
        }

        public Material GetMaterialById(int id)
        {
            return _repository.Get(id);
        }

        public void CreateMaterial(Material Material)
        {
            _repository.Create(Material);
        }

        public void UpdateMaterial(Material Material)
        {
            _repository.Update(Material);
        }

        public void DeleteMaterial(int id)
        {
            _repository.Delete(id);
        }


    }
}
