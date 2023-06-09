using EasyCashIdentity.EntityLayer.Concrete;
using EasyCashIdentity.BusinessLayer.Abstract;
using EasyCashIdentity.DataAccessLayer.Abstract;

namespace EasyCashIdentity.BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void Add(CustomerAccount entity)
        {
            _customerAccountDal.Add(entity);
        }

        public void Delete(CustomerAccount entity)
        {
            _customerAccountDal.Delete(entity);
        }

        public CustomerAccount GetById(int id)
        {
            return _customerAccountDal.GetById(id);
        }

        public List<CustomerAccount> GetList()
        {
            return _customerAccountDal.GetList();
        }

        public void Update(CustomerAccount entity)
        {
            _customerAccountDal.Update(entity);
        }
    }
}