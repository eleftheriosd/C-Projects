using System;
using System.Collections.Generic;
using System.Text;
using Dataverse.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dataverse.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Contact> Contacts
        {
            get;
            set;
        }
        public DbSet<Phone> Phones
        {
            get;
            set;
        }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contacts");
                entity.HasKey(x => x.ContactId);
                entity.HasMany(c => c.Phones).WithOne(x => x.Contact).HasForeignKey(f => f.PhoneId);
            });

            builder.Entity<Phone>(entity => {
                entity.ToTable("Phones");
                entity.HasKey(x => x.PhoneId);
                
            });
        }
    }
}
