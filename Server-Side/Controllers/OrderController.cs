using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Server_Side.Interface;
using Server_Side.Model;
using Server_Side.Model.Commands;
using Server_Side.SignalRHubs;
using System.Security.Claims;
using System.Security.Cryptography.Xml;

namespace Server_Side.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        const string allUsers = "user,admin";
        private readonly IOrdersRepository _repo;
        private readonly IHubContext<OrdersHub> _hubContext;

        public OrderController(IOrdersRepository repo, IHubContext<OrdersHub> hubContext)
        {
            _repo = repo;
            _hubContext = hubContext;
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
        public ActionResult AddOrder(CreateOrderCommand command)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                //return _repo.AddOrderAsync(command);
                var order = _repo.AddOrderAsync(command);
                _hubContext.Clients.All.SendAsync("receiveOrder", order.Result);
                return Ok();
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
                var order =  _repo.UpdateOrderAsync(command);
                _hubContext.Clients.All.SendAsync("receiveEdit", order.Result);
                return Ok();
            }
            return null;
        }

        [HttpDelete("deleteOrder/{orderId}")]
        [Authorize(Roles = allUsers)]
        public ActionResult DestroyOrder(Guid orderId)
        {

            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                 var order =_repo.DeleteOrderAsync(orderId);
                _hubContext.Clients.All.SendAsync("receiveDelete", order.Result);
                return Ok();
            }
            return null;

        }
    }
}
