using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PagingApp.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
    }

    public class MobileInitializer : DropCreateDatabaseAlways<MobileContext>
    {

        protected override void Seed(MobileContext db)
        {
            db.Phones.Add(new Phone { Model = "Samsung Galaxy III", Producer = "Samsung" });
            db.Phones.Add(new Phone { Model = "Samsung Ace II", Producer = "Samsung" });
            db.Phones.Add(new Phone { Model = "HTC Hero", Producer = "HTC" });
            db.Phones.Add(new Phone { Model = "HTC One S", Producer = "HTC" });
            db.Phones.Add(new Phone { Model = "HTC One X", Producer = "HTC" });
            db.Phones.Add(new Phone { Model = "LG Optimus 3D", Producer = "LG" });
            db.Phones.Add(new Phone { Model = "Nokia N9", Producer = "Nokia" });
            db.Phones.Add(new Phone { Model = "Samsung Galaxy Nexus", Producer = "Samsung" });
            db.Phones.Add(new Phone { Model = "Sony Xperia X10", Producer = "SONY" });
            db.Phones.Add(new Phone { Model = "Samsung Galaxy II", Producer = "Samsung" });
        }
    }
}