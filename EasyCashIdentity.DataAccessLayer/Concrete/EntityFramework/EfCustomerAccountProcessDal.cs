using EasyCashIdentity.EntityLayer.Concrete;
using EasyCashIdentity.DataAccessLayer.Abstract;
using EasyCashIdentity.DataAccessLayer.Concrete.EntityFramework.Contexts;
using EasyCashIdentity.CoreLayer.EasyCashIdentity.DataAccessLayer.Concrete.EntityFramework;

namespace EasyCashIdentity.DataAccessLayer.Concrete.EntityFramework
{
    public class EfCustomerAccountProcessDal : EfEntityRepositoryBase<CustomerAccountProcess, DatabaseContext>, ICustomerAccountProcessDal
    {

    }
}