using BasicCrm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrm.Entities.Concrete
{
    public class Admin : IEntity
    {
        public Nullable<int> AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
    }
}
