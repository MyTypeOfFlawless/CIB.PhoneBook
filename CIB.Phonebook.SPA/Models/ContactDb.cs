﻿using System.Data.Entity;

namespace CIB.PhoneBook.SPA.Models
{
    public class ContactDb : DbContext
    {
        public ContactDb()
            : base("data source=.;initial catalog=CIB.PhoneBook;persist security info=True;user id=sa;password=Leg@l123;MultipleActiveResultSets=True;App=EntityFramework")
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}