using Microsoft.AspNetCore.Identity;
using EasyCashIdentity.CoreLayer.EasyCashIdentity.EntityLayer.Abstract;

namespace EasyCashIdentity.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public int ConfirmCode { get; set; }
        public bool Status { get; set; }

        #region Table relationship
        public List<CustomerAccount> CustomerAccounts { get; set; }
        #endregion
    }
}