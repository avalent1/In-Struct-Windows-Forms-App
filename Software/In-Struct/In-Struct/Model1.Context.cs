﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace In_Struct
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PI2301_DBEntities : DbContext
    {
        public PI2301_DBEntities()
            : base("name=PI2301_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Instrukcija> Instrukcijas { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Racun> Racuns { get; set; }
        public virtual DbSet<Recenzija> Recenzijas { get; set; }
        public virtual DbSet<Termin> Termins { get; set; }
        public virtual DbSet<Tip_recenzije> Tip_recenzije { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }
        public virtual DbSet<pripada> pripadas { get; set; }
    }
}
