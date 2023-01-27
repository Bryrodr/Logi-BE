namespace Server_Side.Model.Commands
{
    public class ResetPasswordCommand
    {
        public string PasswordHash { get; set; }
        public string userInfo { get; set; }
    }
}
