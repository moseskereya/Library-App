using Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Library.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() :base("LibraryContext")
        {

        }
            public DbSet<Book> books { get; set; }
            public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}
    