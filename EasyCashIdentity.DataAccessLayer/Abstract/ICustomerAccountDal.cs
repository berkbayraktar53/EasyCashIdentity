using EasyCashIdentity.EntityLayer.Concrete;
using EasyCashIdentity.CoreLayer.EasyCashIdentity.DataAccessLayer.Abstract;

namespace EasyCashIdentity.DataAccessLayer.Abstract
{
    public interface ICustomerAccountDal : IEntityRepository<CustomerAccount>
    {

    }
}