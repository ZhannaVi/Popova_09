﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Popova_09.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Monk_PopovaEntities1 : DbContext
    {
        private static Monk_PopovaEntities1 _context;
        public Monk_PopovaEntities1()
            : base("name=Monk_PopovaEntities1")
        {
        }
    
        public static Monk_PopovaEntities1 GetContext()
        {
            if(_context == null)
            {
                _context = new Monk_PopovaEntities1();
            }
            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Monkey> Monkeys { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ViewMonkey> ViewMonkeys { get; set; }
    }
}
