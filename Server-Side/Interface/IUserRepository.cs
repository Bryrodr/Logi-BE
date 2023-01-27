using Server_Side.Model;
using Server_Side.Model.Commands;

namespace Server_Side.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
   
        Task<string> AddUserAsync(UserViewModel command);
        Task<User> DeleteUserAsync(string Username);
        Task<string> LoginUserAsync(LoginUserCommand command);

        Task<string> verifyUserExists(SmsCommand userInfo);

        Task<User> resetPassword(ResetPasswordCommand command);


    }
}
