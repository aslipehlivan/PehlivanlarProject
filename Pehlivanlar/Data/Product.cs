using System;
using System.Collections.Generic;
using System.Text;

namespace Pehlivanlar.Data
{
    public class Product
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Color { get; set; }
        public int Properties { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public int Stock { get; set; }

    }
}
