using System;
using System.Collections.Generic;
using System.Text;

namespace Pehlivanlar.User
{
    public class Roles
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool CanChangePassword { get; set; }
        public bool CanChangePrice { get; set; }
        public bool CanChangeStock { get; set; }

    }
}
