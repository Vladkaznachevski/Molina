using Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Molina.Models.ViewModels
{
    public class ClothViewModel
    {

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public int Selected { get; set; }

        public int Selected2 { get; set; }

        public int Selected3 { get; set; }

        public List<Class> Classes { get; set; }
        public List<Material> Materials { get; set; }
        public List<Size> Sizes { get; set; }

    }
}
