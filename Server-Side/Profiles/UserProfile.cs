using AutoMapper;
using Server_Side.Model;
using Server_Side.Model.Commands;

namespace Server_Side.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel >().ReverseMap();
            CreateMap<User, ResetPasswordCommand>().ReverseMap();
        }
    }
}
