﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datahantering.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatahanteringEntities : DbContext
    {
        public DatahanteringEntities()
            : base("name=DatahanteringEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<movie_data>()
        .HasOptional(a => a.movie_actor)
        .WithOptionalDependent()
        .WillCascadeOnDelete(true);
            //throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<movie_actor> movie_actor { get; set; }
        public virtual DbSet<movie_data> movie_data { get; set; }
    }
}
