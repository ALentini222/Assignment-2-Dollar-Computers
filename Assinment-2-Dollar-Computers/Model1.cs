using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
/*
 * Andreas Lentini 1141007
 * Comp 1098
 * Assignment 2
 * */
namespace Assinment_2_Dollar_Computers
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ComputerProducts")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
