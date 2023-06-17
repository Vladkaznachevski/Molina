using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Molina.Models.ViewModels;
using Molina.Models.ViewModels.Default;
using Services.ClassSer;
using Services.ClothSer;
using Services.MaterialSer;
using Services.SizeSer;

namespace Molina.Controllers
{
    public class AdminClothController : Controller
    {


        private IClassService _ClassService;
        private IMaterialService _MaterialService;
        private ISizeService _SizeService;
        private IClothService _ClothService;

        public AdminClothController(IClassService ClassService, IMaterialService MaterialService, ISizeService SizeService, IClothService ClothService)
        {
            _ClassService = ClassService;
            _MaterialService = MaterialService;
            _SizeService = SizeService;
            _ClothService = ClothService;
        }


        [HttpGet]
        public IActionResult CreateCloth()
        {

            ClothViewModel model = new ClothViewModel()
            {
                Classes = _ClassService.GetClasses(),
                Materials = _MaterialService.GetMaterials(),
                Sizes = _SizeService.GetSizes()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateCloth(ClothViewModel model)
        {

                Cloth Cloth = new Cloth()
                {
                    Id = model.Id,
                    Price = model.Price,
                    Name = model.Name,
                    ClassId = model.Selected,
                    MaterialId = model.Selected2,
                    SizeId = model.Selected3,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                };

                _ClothService.CreateCloth(Cloth);

                return RedirectToAction("ClothsList", "AdminCloth");

        }


        public async Task<IActionResult> ClothsList(string search, int? Cloth, SortState sortOrder = SortState.NameDesc, int page = 1)
        {
            int pageSize = 2;

            List<Cloth> Clothes = _ClothService.GetCloths();


            if (!String.IsNullOrEmpty(search))
            {
                Clothes = Clothes.Where(p => p.Name.Contains(search)).ToList();
            }



            switch (sortOrder)
            {
                case SortState.NameDesc:
                    Clothes = Clothes.OrderByDescending(s => s.Name).ToList();
                    break;
            }


            var count = Clothes.Count();
            var items = Clothes.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ClothesListViewModel model = new ClothesListViewModel
                (
                    items,
                    new PageViewModel(count, page, pageSize),
                    new SortViewModel(sortOrder),
                    new FilterViewModel(Cloth, search)
                );


            return View(model);
        }






        public IActionResult Index()
        {
            return View();
        }
    }
}
