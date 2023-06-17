using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ClothRepo
{
    public class ClothRepository : IClothRepository
    {
        private readonly ApplicationContext _context;

        public ClothRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Cloth> GetAll()
        {
            return _context.Cloths.ToList();
        }

        public Cloth Get(int id)
        {
            return _context.Cloths.FirstOrDefault(b => b.Id == id);
        }

        public void Create(Cloth Cloth)
        {
            _context.Cloths.Add(Cloth);
            _context.SaveChanges();
        }

        public void Update(Cloth Cloth)
        {
            _context.Cloths.Update(Cloth);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Cloth Cloth = Get(id);
            _context.Cloths.Remove(Cloth);
            _context.SaveChanges();
        }

    }
}
