using EasyCashIdentity.CoreLayer.EasyCashIdentity.EntityLayer.Abstract;

namespace EasyCashIdentity.EntityLayer.Dtos
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}