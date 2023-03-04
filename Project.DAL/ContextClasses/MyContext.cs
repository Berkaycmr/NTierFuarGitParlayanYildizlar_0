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
    //DAL katmanımız görevi veritabanı ile iletişimi sağlamaktır. EntityFramework indirmek zorunludur. (Referanslara baktığınızda hata alıyorsanız Build etmenizi tavsiye ediyoruz.)
    
    //ÖNEMLİ: Bu katmanda, UI katmanından referans aldığınız takdirde büyük bir güvenlik risk'i ile karşı karşıya kalabilirsiniz!  
    
    public class MyContext : DbContext
    {//MyContext'e DbContext'den miras vererek, ona bir veritabanı sınıfı olduğunu bildirmiş oluyoruz.

        public MyContext() : base("MyConnection")
        {//*BAŞLANGIÇ* projesinin AppConfig eylemleri içerisinden veritabanı özelliklerimizi alıp gerçekleştirecek olan Constructor'dır.

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {//Map katmanından veritabanı ayarlamalarımızı alıyoruz. (Aşağıdaki işlemleri yapabilmeniz için Map ve Entities katmanlarının referansı Dal katmanında da olmalıdır.)

         //Bu işlemleri gerçekleştirebilmek için Map ve Entities katmanlarının işlemlerinin bitmiş olması gerekmektedir.

            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserProfileMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new CustomerRequestMap());
            modelBuilder.Configurations.Add(new IssueMap());
            modelBuilder.Configurations.Add(new RequestIssueMap());
            modelBuilder.Configurations.Add(new RequestMap());
            modelBuilder.Configurations.Add(new SaloonMap());
            modelBuilder.Configurations.Add(new SaloonSponsorMap());
            modelBuilder.Configurations.Add(new SponsorMap());
            
        }

        //Tablo olabilmeleri için DbSetlerimizi tanımlıyoruz.
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerRequest> CustomerRequests { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestIssue> RequestIssues { get; set; }
        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<SaloonSponsor> SaloonSponsors { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }

    }

    //Sıradaki işlem migration işlemi olacaktır ve DAL katmanı ile olan işlemlerimiz sonlanacaktır.
}
