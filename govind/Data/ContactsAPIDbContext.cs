using Microsoft.EntityFrameworkCore;
using CondidateCodeTest.model;

namespace CondidateCodeTest.Data
{
    public class ContactsAPIDbContext:DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }

       
    }
   
}
