using EasyCashIdentity.EntityLayer.Concrete;
using EasyCashIdentity.BusinessLayer.Abstract;
using EasyCashIdentity.DataAccessLayer.Abstract;

namespace EasyCashIdentity.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void Add(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Add(entity);
        }

        public void Delete(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Delete(entity);
        }

        public CustomerAccountProcess GetById(int id)
        {
            return _customerAccountProcessDal.GetById(id);
        }

        public List<CustomerAccountProcess> GetList()
        {
            return _customerAccountProcessDal.GetList();
        }

        public void Update(CustomerAccountProcess entity)
        {
            _customerAccountProcessDal.Update(entity);
        }
    }
}