﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZEP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZepContext : DbContext
    {
        public ZepContext()
            : base("name=ZepContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Function> Function { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Location_Classificator> Location_Classificator { get; set; }
        public virtual DbSet<Location_Classified> Location_Classified { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Model_Classificator> Model_Classificator { get; set; }
        public virtual DbSet<Model_Classified> Model_Classified { get; set; }
        public virtual DbSet<Model_Object_Task> Model_Object_Task { get; set; }
        public virtual DbSet<Object> Object { get; set; }
        public virtual DbSet<Object_Classificator> Object_Classificator { get; set; }
        public virtual DbSet<Object_Classificator_2> Object_Classificator_2 { get; set; }
        public virtual DbSet<Object_Classified> Object_Classified { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Predecessor> Predecessor { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Task_Classificator> Task_Classificator { get; set; }
        public virtual DbSet<Task_Classified> Task_Classified { get; set; }
        public virtual DbSet<Data> Data { get; set; }
        public virtual DbSet<main_View> main_View { get; set; }
    }
}
