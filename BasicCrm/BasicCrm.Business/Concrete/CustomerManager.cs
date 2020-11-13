using BasicCrm.Business.Abstract;
using BasicCrm.Business.Utilities;
using BasicCrm.Business.ValidationRules.FluentValidation;
using BasicCrm.DataAccess.Abstract;
using BasicCrm.DataAccess.Concrete.EntityFramework;
using BasicCrm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrm.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            if (_customerDal.Get(customer) != null)
            {
                _customerDal.Delete(customer);
            }
            else
            {
                throw new Exception("The Customer You Try to Delete Doesn't Exist or is Already Deleted!");
            }
        }

        public Customer Get(int _id)
        {
            return _customerDal.Get(new Customer() { Id = _id });
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll(new Customer());
        }

        public void Update(Customer customer)
        {
            if (_customerDal.Get(customer) != null)
            {
                ValidationTool.Validate(new CustomerValidator(), customer);
                _customerDal.Update(customer);
            }
            else
            {
                throw new Exception("The Customer You Try to Update Doesn't Exist or is Deleted!");
            }
        }
    }
}
