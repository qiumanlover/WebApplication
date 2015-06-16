using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_Study.Models
{
    public class MusicStoreDBInitializer : System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDBContext>
    {
        protected override void Seed(MusicStoreDBContext context)
        {
            context.Artists.Add(new Artist { Name = "周杰伦" });
            //context.Artists.Add(new Artist { Name = "Beyond" });
            context.Genres.Add(new Genre { Name = "中国风" });
            //context.Genres.Add(new Genre { Name = "Rock" });
            context.Albums.Add(new Album { Artist = new Artist { Name = "陈奕迅" }, Genre = new Genre { Name = "R&P" }, Price = 1200, Title = "Caravan" });
            base.Seed(context);
        }
    }
}