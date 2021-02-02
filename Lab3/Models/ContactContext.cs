using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                
                    new Category{CategoryId = 1, name = "Family"},
                    new Category{CategoryId = 2, name = "Friend"},
                    new Category{CategoryId = 3, name = "Work"},
                    new Category{CategoryId = 4, name = "Other"} );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    firstName = "Bruce",
                    lastName = "Wayne",
                    phone = "416-123-4567",
                    email = "bruce.wayne@domain.com",
                    CategoryId = 1,
                    dateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 2,
                    firstName = "Peter",
                    lastName = "Parker",
                    phone = "647-123-4567",
                    email = "peter.parker@domain.com",
                    CategoryId = 1,
                    dateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 3,
                    firstName = "Diana",
                    lastName = "Prince",
                    phone = "647-233-4567",
                    email = "diana.prince@domain.com",
                    CategoryId = 3,
                    dateAdded = DateTime.Now
                }
                );
        }
    }
}
