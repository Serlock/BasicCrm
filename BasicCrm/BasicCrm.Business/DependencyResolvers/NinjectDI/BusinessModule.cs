using BasicCrm.Business.Abstract;
using BasicCrm.Business.Concrete;
using BasicCrm.DataAccess.Abstract;
using BasicCrm.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrm.Business.DependencyResolvers.NinjectDI
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();

            Bind<IAdminService>().To<AdminManager>().InSingletonScope();
            Bind<IAdminDal>().To<EfAdminDal>().InSingletonScope();
        }
    }
}
