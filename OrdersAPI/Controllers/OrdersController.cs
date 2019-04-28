using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrdersAPI.Controllers
{
    [Route("api/Orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET api/Orders
        [HttpGet, Route("")]
        public IActionResult GetOrders()
        {
            var o1 = new Order("Order1", 205);
            var o2 = new Order("Order2",350);
            return Ok(
                new List<Order> { o1, o2 });
        }

    }
    public class Order
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public Order(string id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }
    }
}
