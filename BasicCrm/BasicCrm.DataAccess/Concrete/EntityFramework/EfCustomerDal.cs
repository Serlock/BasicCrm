using BasicCrm.DataAccess.Abstract;
using BasicCrm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BasicCrm.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, BasicCrmContext>, ICustomerDal
    {

    }
}
