﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZepProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZEPEntities : DbContext
    {
        public ZEPEntities()
            : base("name=ZEPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Department_Object> Department_Object { get; set; }
        public virtual DbSet<Department_User> Department_User { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Object> Object { get; set; }
        public virtual DbSet<Object_Document> Object_Document { get; set; }
        public virtual DbSet<Object_Document_Parameter> Object_Document_Parameter { get; set; }
        public virtual DbSet<Object_Library> Object_Library { get; set; }
        public virtual DbSet<Object_Object> Object_Object { get; set; }
        public virtual DbSet<Object_Speciality> Object_Speciality { get; set; }
        public virtual DbSet<Parameter> Parameter { get; set; }
        public virtual DbSet<Parameter_Parameter> Parameter_Parameter { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<Specialty> Specialty { get; set; }
        public virtual DbSet<Station> Station { get; set; }
        public virtual DbSet<Station_Object> Station_Object { get; set; }
        public virtual DbSet<Station_User> Station_User { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Variation> Variation { get; set; }
        public virtual DbSet<Variation_Object> Variation_Object { get; set; }
    }
}