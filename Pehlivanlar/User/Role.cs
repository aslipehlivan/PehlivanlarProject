using System;
using System.Collections.Generic;
using System.Text;

namespace Pehlivanlar.User
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool CanChangePassword { get; set; }
        public bool CanChangePrice { get; set; }
        public bool CanChangeStock { get; set; }
}

    public enum RoleType
    {
        Admin = 1,
        Staff = 2
    }
}
