﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeapFinal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LeapNullEntities : DbContext
    {
        public LeapNullEntities()
            : base("name=LeapNullEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LanguageTable> LanguageTables { get; set; }
        public virtual DbSet<UserLanguageTable> UserLanguageTables { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    
        public virtual int sp_AssignTeacher(string learnerEmail, string lName, ObjectParameter teacherEmail)
        {
            var learnerEmailParameter = learnerEmail != null ?
                new ObjectParameter("LearnerEmail", learnerEmail) :
                new ObjectParameter("LearnerEmail", typeof(string));
    
            var lNameParameter = lName != null ?
                new ObjectParameter("LName", lName) :
                new ObjectParameter("LName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AssignTeacher", learnerEmailParameter, lNameParameter, teacherEmail);
        }
    }
}