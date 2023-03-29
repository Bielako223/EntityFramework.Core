using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_net_ef_test.DataAccess
{
    public class PeopleContext: DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }


    }
}
