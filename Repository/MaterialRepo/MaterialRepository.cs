using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.MaterialRepo
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly ApplicationContext _context;

        public MaterialRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Material> GetAll()
        {
            return _context.Materials.ToList();
        }

        public Material Get(int id)
        {
            return _context.Materials.FirstOrDefault(b => b.Id == id);
        }

        public void Create(Material Material)
        {
            _context.Materials.Add(Material);
            _context.SaveChanges();
        }

        public void Update(Material Material)
        {
            _context.Materials.Update(Material);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Material Material = Get(id);
            _context.Materials.Remove(Material);
            _context.SaveChanges();
        }


    }
}
