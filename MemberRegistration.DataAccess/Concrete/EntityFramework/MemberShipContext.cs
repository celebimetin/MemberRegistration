using MemberRegistration.DataAccess.Concrete.EntityFramework.Mappings;
using MemberRegistration.Entities.Concrete;
using System.Data.Entity;

namespace MemberRegistration.DataAccess.Concrete.EntityFramework
{
    public class MemberShipContext : DbContext
    {
        public MemberShipContext()
        {
            Database.SetInitializer<MemberShipContext>(null);
        }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
        }
    }
}