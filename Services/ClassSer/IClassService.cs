using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ClassSer
{
    public interface IClassService
    {
        List<Class> GetClasses();
        Class GetClassById(int id);
        void CreateClass(Class Class);
        void UpdateClass(Class Class);
        void DeleteClass(int id);
    }
}
