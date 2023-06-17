using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MaterialSer
{
    public interface IMaterialService
    {

        List<Material> GetMaterials();
        Material GetMaterialById(int id);
        void CreateMaterial(Material Material);
        void UpdateMaterial(Material Material);
        void DeleteMaterial(int id);

    }
}
