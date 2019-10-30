using Coffee.Models;
using Coffee.Services;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Coffee.Hubs
{
    public class CoffeeHub : Hub
    {
        private readonly IOrderService orderService;

        public CoffeeHub(IOrderService orderService)
        {
            this.orderService = orderService;
        }


        public async Task GetUpdateForOrder(int orderId)
        {
            CheckResult result;

            do
            {
                result = this.orderService.GetUpdate(orderId);

                if (result.New)
                {
                    await this.Clients.Caller.SendAsync("RecceiveOrderUpdate", result.Update);
                }

            } while (!result.Finished);

            await this.Clients.Caller.SendAsync("Finished");
        }
    }
}
