using BasicCrm.Business.Abstract;
using BasicCrm.DataAccess.Abstract;
using BasicCrm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrm.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin Get(string adminName, string adminPassword)
        {
            return  _adminDal.Get(new Admin() { AdminName = adminName, AdminPassword = adminPassword });
        }
    }
}
