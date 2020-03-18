﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace EFStudiiDeCaz
{
    class BusinessContext : DbContext
    {
        public DbSet<Model.Business> Businesses { get; set; }
     

        public BusinessContext() : base("name=BusinessContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          
        }
    }
}
