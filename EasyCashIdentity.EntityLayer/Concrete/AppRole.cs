using Microsoft.AspNetCore.Identity;
using EasyCashIdentity.CoreLayer.EasyCashIdentity.EntityLayer.Abstract;

namespace EasyCashIdentity.EntityLayer.Concrete
{
	public class AppRole : IdentityRole<int>, IEntity
	{
		public string Description { get; set; }
		public bool Status { get; set; }
	}
}