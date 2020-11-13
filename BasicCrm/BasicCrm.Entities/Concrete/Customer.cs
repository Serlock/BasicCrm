using BasicCrm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrm.Entities.Concrete
{
    public class Customer : IEntity
    {
        public Nullable<int> Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public Nullable<byte> Age { get; set; }
        public char Gender { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
        
    }
}
