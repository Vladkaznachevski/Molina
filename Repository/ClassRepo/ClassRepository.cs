using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ClassRepo
{
    public class ClassRepository : IClassRepository
    {
        private readonly ApplicationContext _context;

        public ClassRepository(ApplicationContext context)
        {
            _context = context;
        }
        public List<Class> GetAll()
        {
            return _context.Classes.ToList();
        }
        public Class Get(int id)
        {
            return _context.Classes.FirstOrDefault(b => b.Id == id);
        }
        public void Create(Class Class)
        {
            _context.Classes.Add(Class);
            _context.SaveChanges();
        }
        public void Update(Class Class)
        {
            _context.Classes.Update(Class);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Class Class = Get(id);
            _context.Classes.Remove(Class);
            _context.SaveChanges();
        }

    }
}
