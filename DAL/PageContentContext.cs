using System;
using System.Collections.Generic;
using System.Linq;
using BPEC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BPEC.DAL
{
    public class PageContentContext:DbContext
    {
        public DbSet<PageContent> PagesContent { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Client> Clients { get; set; }
    }
}