using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Models;
using Project.MAP.Options;

namespace Project.DAL.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserProfileMap());
            modelBuilder.Configurations.Add(new CafeMap());
            modelBuilder.Configurations.Add(new CafeRequestMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new FairMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new MeetingRoomMap());
            modelBuilder.Configurations.Add(new MeetingRoomRequestMap());
            modelBuilder.Configurations.Add(new RequestMap());
            modelBuilder.Configurations.Add(new SaloonMap());
            modelBuilder.Configurations.Add(new SaloonCustomerMap());
            modelBuilder.Configurations.Add(new SaloonSponsorMap());
            modelBuilder.Configurations.Add(new SectionMap());
            modelBuilder.Configurations.Add(new SponsorMap());
            modelBuilder.Configurations.Add(new ToiletMap());
            modelBuilder.Configurations.Add(new ToiletRequestMap());
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Cafe> Cafes { get; set; }
        public DbSet<CafeRequest> CafeRequests { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Fair> Fairs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MeetingRoom> MeetingRooms { get; set; }
        public DbSet<MeetingRoomRequest> MeetingRoomRequests { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<SaloonCustomer> SaloonCustomers { get; set; }
        public DbSet<SaloonSponsor> SaloonSponsors { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Toilet> Toilets { get; set; }
        public DbSet<ToiletRequest> ToiletRequests { get; set; }

    }
}
