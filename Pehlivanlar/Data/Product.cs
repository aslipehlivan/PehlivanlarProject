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
        public string Properties { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
