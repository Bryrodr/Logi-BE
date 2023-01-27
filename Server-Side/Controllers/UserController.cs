using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.IdentityModel.Tokens;
using Server_Side.Interface;
using Server_Side.Model;
using Server_Side.Model.Commands;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Server_Side.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    { 
        private readonly IUserRepository _repo;
        public UserController( IUserRepository repo)
        {
            _repo = repo;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public ActionResult RegisterUser(UserViewModel Model)
        {

            return Ok(_repo.AddUserAsync(Model).Result);
        }
        [AllowAnonymous]
        [HttpPost("login/")]
        public ActionResult LoginUser(LoginUserCommand command)
        {
            var user = _repo.LoginUserAsync(command);
            return Ok(user.Result);
        }

        [AllowAnonymous]
        [HttpGet("getAllUsers")]
        public async Task<List<User>> GetAllUsers()
        {
            return await _repo.GetUsersAsync();
        }

        [AllowAnonymous]
        [HttpPost("sendSms")]
        public ActionResult<string> SendSms(SmsCommand userInfo)
        {
            return _repo.verifyUserExists(userInfo).Result;
        }

        [AllowAnonymous]
        [HttpPut("resetPassword")]
        public ActionResult ResetPassword(ResetPasswordCommand command)
        {
            return Ok(_repo.resetPassword(command).Result);
        }
    }
}
