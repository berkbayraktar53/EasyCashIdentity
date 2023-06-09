using EasyCashIdentity.CoreLayer.EasyCashIdentity.EntityLayer.Abstract;

namespace EasyCashIdentity.EntityLayer.Dtos
{
    public class ConfirmEmailDto : IDto
    {
        public string Email { get; set; }
        public int ConfirmCode { get; set; }
    }
}