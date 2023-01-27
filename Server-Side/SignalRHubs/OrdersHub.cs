using Microsoft.AspNetCore.SignalR;
using Server_Side.Model;
using Server_Side.Model.Commands;

namespace Server_Side.SignalRHubs
{
    public class OrdersHub:Hub
    {
        
        public async Task sendOrder(Order order)
        {
            await Clients.All.SendAsync("receiveOrder", "potato");
        }
    }
}
