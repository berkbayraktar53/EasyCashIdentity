using EasyCashIdentity.CoreLayer.EasyCashIdentity.EntityLayer.Abstract;

namespace EasyCashIdentity.EntityLayer.Concrete
{
	public class CustomerAccountProcess : IEntity
	{
		public int Id { get; set; }
		public string ProcessType { get; set; }
		public DateTime ProcessDate { get; set; }
		public decimal Amount { get; set; }
		public bool Status { get; set; }
	}
}