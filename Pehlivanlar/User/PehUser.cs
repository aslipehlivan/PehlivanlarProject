using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pehlivanlar.User
{
    public class PehUser
    {

        public int ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string UserName { get; set; }
        [Required]
        [StringLength(256)]
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; }
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }

    }
}
