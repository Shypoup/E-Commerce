﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IA_PM.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IAEn : DbContext
    {
        public IAEn()
            : base("name=IAEn")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<hiring> hirings { get; set; }
        public virtual DbSet<progress> progresses { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<projrequest> projrequests { get; set; }
        public virtual DbSet<request> requests { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<usertype> usertypes { get; set; }
    }
}
