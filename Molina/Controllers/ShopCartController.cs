using Data;
using Microsoft.AspNetCore.Mvc;
using Molina.Models.ViewModels;
using Repository.ShopCartRepo;
using Services.ClothSer;

namespace Molina.Controllers
{

    public class ShopCartController : Controller
    {
        private IClothService _ClothService;
        private ShopCartRepository _shopCartRepository;
        public ShopCartController(ShopCartRepository shopCartRepository, IClothService ClothService)
        {
            _shopCartRepository = shopCartRepository;
            _ClothService = ClothService;
        }
        public ViewResult Index()
        {
            var items = _shopCartRepository.GetShopItems();
            _shopCartRepository.listShopItems = items;

            var obj = new ShopCartViewModel { ShopCartRepository = _shopCartRepository };

            return View(obj);

        }
        public RedirectToActionResult AddToCart(int id)
        {

            Cloth item = _ClothService.GetClothById(id);
            _shopCartRepository.AddToCart(item);


            return RedirectToAction("Index");
        }
    }
}
