using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.SizeRepo
{
    public class SizeRepository : ISizeRepository
    {

        private readonly ApplicationContext _context;

        public SizeRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Size> GetAll()
        {
            return _context.Sizes.ToList();
        }

        public Size Get(int id)
        {
            return _context.Sizes.FirstOrDefault(b => b.Id == id);
        }

        public void Create(Size Size)
        {
            _context.Sizes.Add(Size);
            _context.SaveChanges();
        }

        public void Update(Size Size)
        {
            _context.Sizes.Update(Size);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Size Size = Get(id);
            _context.Sizes.Remove(Size);
            _context.SaveChanges();
        }

    }
}
