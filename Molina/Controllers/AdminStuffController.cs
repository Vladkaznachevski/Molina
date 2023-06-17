using Data;
using Molina.Models.ViewModels.Default;
using Microsoft.AspNetCore.Mvc;
using Molina.Models.ViewModels;
using Services;
using Services.ClassSer;
using Services.MaterialSer;
using Services.SizeSer;

namespace Molina.Controllers
{
    public class AdminStuffController : Controller
    {


        private IClassService _ClassService;
        private IMaterialService _MaterialService;
        private ISizeService _SizeService;

        public AdminStuffController(IClassService ClassService, IMaterialService MaterialService, ISizeService SizeService)
        {
            _ClassService = ClassService;
            _MaterialService = MaterialService;
            _SizeService = SizeService;
        }


        [HttpGet]
        public IActionResult CreateClass()
        {
            Class model = new Class();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateClass(Class model)
        {
            if (ModelState.IsValid)
            {

                Class Class = new Class()
                    {
                        Id = model.Id,
                        Name = model.Name,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                    };

                    _ClassService.CreateClass(Class);

               // return RedirectToAction("ClothsList", "AdminCloth");
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult CreateMaterial()
        {
            Material model = new Material();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateMaterial(Material model)
        {
            if (ModelState.IsValid)
            {
                Material Material = new Material()
                {
                    Id = model.Id,
                    Name = model.Name,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                };
                _MaterialService.CreateMaterial(Material);

               // return RedirectToAction("ClothsList", "AdminCloth");
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult CreateSize()
        {
            Size model = new Size();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateSize(Size model)
        {
            if (ModelState.IsValid)
            {
                Size Size = new Size()
                {
                    Id = model.Id,
                    Name = model.Name,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                };
                _SizeService.CreateSize(Size);

              //  return RedirectToAction("ClothsList", "AdminCloth");
            }
            return View(model);
        }




        public async Task<IActionResult> ClassList(string search, int? Cloth, SortState sortOrder = SortState.NameDesc, int page = 1)
        {
            int pageSize = 2;

            List<Class> Classes = _ClassService.GetClasses();


            if (!String.IsNullOrEmpty(search))
            {
                Classes = Classes.Where(p => p.Name.Contains(search)).ToList();
            }



            switch (sortOrder)
            {
                case SortState.NameDesc:
                    Classes = Classes.OrderByDescending(s => s.Name).ToList();
                    break;
            }


            var count = Classes.Count();
            var items = Classes.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ClassListViewModel model = new ClassListViewModel
                (
                    items,
                    new PageViewModel(count, page, pageSize),
                    new SortViewModel(sortOrder),
                    new FilterViewModel( Cloth, search)
                );


            return View(model);
        }


        public async Task<IActionResult> MaterialsList(string search, int? Cloth, SortState sortOrder = SortState.NameDesc, int page = 1)
        {
            int pageSize = 2;

            List<Material> Classes = _MaterialService.GetMaterials();


            if (!String.IsNullOrEmpty(search))
            {
                Classes = Classes.Where(p => p.Name.Contains(search)).ToList();
            }



            switch (sortOrder)
            {
                case SortState.NameDesc:
                    Classes = Classes.OrderByDescending(s => s.Name).ToList();
                    break;
            }


            var count = Classes.Count();
            var items = Classes.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            MaterialListViewModel model = new MaterialListViewModel
                (
                    items,
                    new PageViewModel(count, page, pageSize),
                    new SortViewModel(sortOrder),
                    new FilterViewModel(Cloth, search)
                );


            return View(model);
        }


        public async Task<IActionResult> SizesList(string search, int? Cloth, SortState sortOrder = SortState.NameDesc, int page = 1)
        {
            int pageSize = 2;

            List<Size> Classes = _SizeService.GetSizes();


            if (!String.IsNullOrEmpty(search))
            {
                Classes = Classes.Where(p => p.Name.Contains(search)).ToList();
            }



            switch (sortOrder)
            {
                case SortState.NameDesc:
                    Classes = Classes.OrderByDescending(s => s.Name).ToList();
                    break;
            }


            var count = Classes.Count();
            var items = Classes.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            SizeListViewModel model = new SizeListViewModel
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
