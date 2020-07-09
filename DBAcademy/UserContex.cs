using System.Data.Entity;

namespace DBAcademy
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<Authorization> Authorizations { get; set; }

    }
}
