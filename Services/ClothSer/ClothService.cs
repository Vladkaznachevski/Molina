using Data;
using Repository.ClothRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ClothSer
{
    public class ClothService : IClothService
    {

        private IClothRepository _repository;

        public ClothService(IClothRepository repository)
        {
            _repository = repository;
        }


        public List<Cloth> GetCloths()
        {
            return _repository.GetAll();
        }

        public Cloth GetClothById(int id)
        {
            return _repository.Get(id);
        }

        public void CreateCloth(Cloth Cloth)
        {
            _repository.Create(Cloth);
        }

        public void UpdateCloth(Cloth Cloth)
        {
            _repository.Update(Cloth);
        }

        public void DeleteCloth(int id)
        {
            _repository.Delete(id);
        }



    }
}
