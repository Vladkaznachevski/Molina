using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ClothSer
{
    public interface IClothService
    {

        List<Cloth> GetCloths();
        Cloth GetClothById(int id);
        void CreateCloth(Cloth Cloth);
        void UpdateCloth(Cloth Cloth);
        void DeleteCloth(int id);
    }
}
