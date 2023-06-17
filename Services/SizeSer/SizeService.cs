using Data;
using Repository.SizeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.SizeSer
{
    public class SizeService : ISizeService
    {


        private ISizeRepository _repository;

        public SizeService(ISizeRepository repository)
        {
            _repository = repository;
        }


        public List<Size> GetSizes()
        {
            return _repository.GetAll();
        }

        public Size GetSizeById(int id)
        {
            return _repository.Get(id);
        }

        public void CreateSize(Size Size)
        {
            _repository.Create(Size);
        }

        public void UpdateSize(Size Size)
        {
            _repository.Update(Size);
        }

        public void DeleteSize(int id)
        {
            _repository.Delete(id);
        }


    }
}
