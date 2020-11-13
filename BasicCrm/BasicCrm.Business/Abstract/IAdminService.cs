using BasicCrm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrm.Business.Abstract
{
    public interface IAdminService
    {
        Admin Get(string adminName, string adminPassword);
    }
}
