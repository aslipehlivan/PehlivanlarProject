using System;
using System.Collections.Generic;
using System.Text;

namespace Pehlivanlar.Data
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
    public enum CatName
    {
        Televizyon = 1,
        Buzolabı = 2,
        ÇamaşırMakinesi = 3,
        BulaşıkMakinesi = 4
    }

}
