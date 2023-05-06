using _1.eTickers.Data.Cart;
using _1.eTickers.Data.Services;
using _1.eTickers.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace _1.eTickers.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IMoviesService _movieService;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrdersService _ordersService;

        public OrdersController(IMoviesService movieService, ShoppingCart shoppingCart, IOrdersService ordersService)
        {
            _movieService = movieService;
            _shoppingCart = shoppingCart;
            _ordersService = ordersService;
        }

        public async Task<IActionResult> Index()
        {
            // Tìm user đang sử dụng hiện tại. (Tất cả User đăng nhập --> Lưu vào Claim)
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);

            var orders = await _ordersService.GetOrdersByUserIdAndRoleAsync(userId, userRole);
            return View(orders);

        }
        
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(response);
        }

    }
}
