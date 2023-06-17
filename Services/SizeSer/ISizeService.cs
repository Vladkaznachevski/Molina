using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.SizeSer
{
    public interface ISizeService
    {

        List<Size> GetSizes();
        Size GetSizeById(int id);
        void CreateSize(Size Size);
        void UpdateSize(Size Size);
        void DeleteSize(int id);

    }
}
