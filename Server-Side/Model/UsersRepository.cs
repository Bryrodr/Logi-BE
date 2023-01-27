
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Server_Side.Interface;
using Server_Side.Model.Commands;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Server_Side.Model
{
    public class UsersRepository : IUserRepository
    {
        private readonly IMapper _mapper;
        private readonly OrderDbContext _dbContext;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IConfiguration _config;
        public UsersRepository( OrderDbContext dbContext, IPasswordHasher passwordHasher, IMapper mapper, IConfiguration config )
        {
            _config = config;
            _mapper = mapper;
            _dbContext = dbContext;
            _passwordHasher = passwordHasher;
        }
        
        public async Task<string> AddUserAsync(UserViewModel command)
        {
            var phone = await _dbContext.Users.FirstOrDefaultAsync(x => x.PhoneNumber == command.PhoneNumber);
            if (phone != null)
            {
                return "1";
            }

            var username = await _dbContext.Users.FirstOrDefaultAsync(x => x.Username == command.Username);
            if (username != null)
            {
                return "2";
            }

            command.PasswordHash = _passwordHasher.HashPassword(command.PasswordHash);
            var user = _mapper.Map<User>(command);
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return "success" ;
        }
  
        public async Task<List<User>> GetUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }
        
        public async Task<string> verifyUserExists(SmsCommand command)
        {
            if (command.userInfo.All(char.IsDigit))
            {
                var phoneNumber = await _dbContext.Users.FirstOrDefaultAsync(x => x.PhoneNumber == command.userInfo);
                if ( phoneNumber != null)
                {
                    return sendMessage(command.userInfo);
                }
                return "1";
            }
            else
            {
                var userName = await _dbContext.Users.FirstOrDefaultAsync(x => x.Username == command.userInfo);
                if (userName != null)
                {
                    return sendMessage(userName.PhoneNumber);
                }
                return "2";
            }
        }
        public async Task<User> resetPassword(ResetPasswordCommand command)
        {
            
            if (command.userInfo.All(char.IsDigit))
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.PhoneNumber == command.userInfo);
                if (user != null)
                {
                    command.PasswordHash = _passwordHasher.HashPassword(command.PasswordHash);
                    _mapper.Map(command, user);
                    _dbContext.Users.Update(user);
                    await _dbContext.SaveChangesAsync();
                    return user;
                }
                return null;
            }
            else
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Username == command.userInfo);
                if (user != null)
                {
                    command.PasswordHash = _passwordHasher.HashPassword(command.PasswordHash);
                    _mapper.Map(command, user);
                    _dbContext.Users.Update(user);
                    await _dbContext.SaveChangesAsync();
                    return user;
                }
                return null;
            }
        }
        
        public async Task<User> DeleteUserAsync(string Username)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Username == Username);
            _dbContext.Users.Remove(user);
             await _dbContext.SaveChangesAsync();
            return user;
        }

        private string GenerateToken(User Model)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, Model.Username),
                new Claim(ClaimTypes.Role,Model.Role)
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            var gen = new JwtSecurityTokenHandler().WriteToken(token);
            return gen;
        }
      
        public async Task<string> LoginUserAsync(LoginUserCommand command)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Username == command.UserName);

            if (user == null)
            {
                return "1";
            }
            if (!_passwordHasher.VerifyHashedPassword(user.PasswordHash, command.Password))
            {
                return "2";
            }
            var token = GenerateToken(user);

            return token;
        }

        public string sendMessage(string number)
        {
            Random r = new Random();
            var x = r.Next(0, 1000000);
            string otp = x.ToString("000000");

            MessageResource.Create(
            body: otp,
            from: new Twilio.Types.PhoneNumber("+13178545833"),
            to: new Twilio.Types.PhoneNumber("+1"+number)
            );
            return otp;
        }
    }
}
