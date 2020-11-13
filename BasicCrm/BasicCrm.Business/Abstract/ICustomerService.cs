using BasicCrm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrm.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer Get(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
