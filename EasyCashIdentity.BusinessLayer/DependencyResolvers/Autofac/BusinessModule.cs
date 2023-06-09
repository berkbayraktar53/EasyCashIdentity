using Autofac;
using EasyCashIdentity.BusinessLayer.Abstract;
using EasyCashIdentity.BusinessLayer.Concrete;
using EasyCashIdentity.DataAccessLayer.Abstract;
using EasyCashIdentity.DataAccessLayer.Concrete.EntityFramework;

namespace EasyCashIdentity.BusinessLayer.DependencyResolvers.Autofac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerAccountManager>().As<ICustomerAccountService>();
            builder.RegisterType<EfCustomerAccountDal>().As<ICustomerAccountDal>();

            builder.RegisterType<CustomerAccountProcessManager>().As<ICustomerAccountProcessService>();
            builder.RegisterType<EfCustomerAccountProcessDal>().As<ICustomerAccountProcessDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<MailManager>().As<IMailService>();
            builder.RegisterType<UserManager>().As<IUserService>();
        }
    }
}