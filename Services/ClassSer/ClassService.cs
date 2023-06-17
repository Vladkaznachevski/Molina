using Data;
using Repository.ClassRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ClassSer
{
    public class ClassService : IClassService
    {

        private IClassRepository _repository;

        public ClassService(IClassRepository repository)
        {
            _repository = repository;
        }


        public List<Class> GetClasses()
        {
            return _repository.GetAll();
        }

        public Class GetClassById(int id)
        {
            return _repository.Get(id);
        }

        public void CreateClass(Class Class)
        {
            _repository.Create(Class);
        }

        public void UpdateClass(Class Class)
        {
            _repository.Update(Class);
        }

        public void DeleteClass(int id)
        {
            _repository.Delete(id);
        }

    }
}
