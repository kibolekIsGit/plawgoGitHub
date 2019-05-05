using plawgoGitHub.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plawgoGitHub.DataAccess
{
    public class DataContext :DbContext
    {
        public DataContext() : base("Name=DefaultConnection")
        {

        }

        public DbSet<Gig> Gigs { get; set; }


        private string _userName = "system";

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private DateTime _now = DateTime.Now;

        public DateTime Now
        {
            get { return _now; }
            set { _now = value; }
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            ObjectContext ctx = ((IObjectContextAdapter)this).ObjectContext;

            foreach (var entity in ctx.ObjectStateManager.GetObjectStateEntries(EntityState.Modified))
            {
                BaseModel baseObject = entity.Entity as BaseModel;

                if (baseObject == null)
                {
                    continue;
                }

                baseObject.UpdateDate = Now;
                baseObject.UpdateUser = UserName;
            }

            foreach (var entity in ctx.ObjectStateManager.GetObjectStateEntries(EntityState.Added))
            {
                BaseModel baseObject = entity.Entity as BaseModel;

                if (baseObject == null)
                {
                    continue;
                }

                baseObject.CreateDate = Now;
                baseObject.UpdateDate = Now;
                baseObject.CreatedUser = UserName;
                baseObject.UpdateUser = UserName;
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gig>()
                .Property(g => g.Venue)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Gig>()
                .Property(g => g.DateTime)
                .IsRequired();


        }
    }
}
