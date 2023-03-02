using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Kullanicilar");
            Property(x => x.UserName).HasColumnName("KullaniciIsmi");
            Property(x => x.Password).HasColumnName("Sifre");

            //Birebir iliski tanımlaması
            HasOptional(x => x.Profile).WithRequreid(x => x.AppUser);
        }
    }
}
