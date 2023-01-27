using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server_Side.Interface;
using Server_Side.Model;
using Server_Side.Model.Commands;
using System.Security.Claims;
using System.Security.Cryptography.Xml;

namespace Server_Side.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        const string allUsers = "user,admin";
        const string adminOnly = "admin";
        private readonly IOrdersRepository _repo;
        public OrderController(IOrdersRepository repo)
        {
            _repo = repo;
        }
        [HttpGet("getorders/")]
        [AllowAnonymous]
        public async Task<List<Order>> GetOrdersAsync()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                return await _repo.GetOrdersAsync();
            }
            return null;
        }
        
        [HttpGet("getOrder/{orderId}")]
        public ActionResult<Order> GetOrder(Guid orderId)
        {
            return  _repo.GetOrderAsync(orderId).Result;
        }
        
        [HttpPost("addOrder/")]
        [Authorize(Roles = allUsers)]
        public ActionResult<Order> AddOrder(CreateOrderCommand command)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                return _repo.AddOrderAsync(command).Result;
            }
            return null;

        }
       

        [HttpPut("updateOrder/{orderId}")]
        [AllowAnonymous]
        public ActionResult UpdateOrder(OrderViewModel command)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                return Ok(_repo.UpdateOrderAsync(command).Result);
            }
            return null;
        }

        [HttpDelete("deleteOrder/{orderId}")]
        [Authorize(Roles = allUsers)]
        public ActionResult<Order> DestroyOrder(Guid orderId)
        {

            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                return _repo.DeleteOrderAsync(orderId).Result;
            }
            return null;

        }
    }
}
