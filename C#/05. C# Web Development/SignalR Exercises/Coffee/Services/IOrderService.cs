using Coffee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.Services
{
    public interface IOrderService
    {
        CheckResult GetUpdate(int orderId);
        int NewOrder();
    }
}
