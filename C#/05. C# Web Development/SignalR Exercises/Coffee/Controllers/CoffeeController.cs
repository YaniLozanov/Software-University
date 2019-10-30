using Coffee.Hubs;
using Coffee.Models;
using Coffee.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coffee.Controllers
{
    public class CoffeeController : Controller
    {
        private CoffeeHub coffeeHub;
        private IOrderService orderService;

        public CoffeeController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> OrderCoffee([FromBody] Order order)
        {
            await this.coffeeHub.Clients.All.SendCoreAsync("NewOrder", new object[]{order});
            var orderId = this.orderService.NewOrder();
            return this.Accepted(orderId);
        }
    }
}
