using Server_Side.Model;
using AutoMapper;
using Server_Side.Model.Commands;

namespace Server_Side.Profiles
{
    public class OrderProfile: Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderViewModel>().ReverseMap();
            CreateMap<Order, CreateOrderCommand>().ReverseMap();
        }
    }
}
