using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirstProject.Models;

namespace CodeFirstProject.Context
{
    public class MyContext:DbContext
    {

        public MyContext() : base("Connection")
        {

        }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<District> Districts { get; set; }

    }
}
