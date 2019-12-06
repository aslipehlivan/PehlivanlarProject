using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pehlivanlar
{
    public class PehlivanlarDb : DbContext
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=PehlivanlarDb;Trusted_Connection=True;";
       
    }
}
