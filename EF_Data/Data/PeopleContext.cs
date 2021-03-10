using EF_Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Data.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }

    }
}
