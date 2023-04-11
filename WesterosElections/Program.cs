using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using WesterosElections.DataAccess;
using WesterosElections.MyModels;

namespace WesterosElections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Register Tribes for the Elections
            var db = new MyDbContext();
            db.Tribes.Add(new Tribe { Name = "Stark" });
            db.Tribes.Add(new Tribe { Name = "Lannister" });
            db.Tribes.Add(new Tribe { Name = "Targaryen" });
            db.Tribes.Add(new Tribe { Name = "Baratheon" });
            db.Tribes.Add(new Tribe { Name = "Vazrazhdane" });
            db.SaveChanges();


            var allTribes = new List<Tribe>();
            foreach (var t in db.Tribes)
            {
                allTribes.Add(t);
            }

            //Register Election Regions
            db.Regions.Add(new Region { RegionName = "Wintherfell", AllTribes = allTribes });
            db.Regions.Add(new Region { RegionName = "KingsLanding", AllTribes = allTribes });
            db.Regions.Add(new Region { RegionName = "CasterlyRock", AllTribes = allTribes });
            db.Regions.Add(new Region { RegionName = "Riverrun", AllTribes = allTribes });
            db.Regions.Add(new Region { RegionName = "MIR24", AllTribes = allTribes });
            db.SaveChanges();











            CreateHostBuilder(args).Build().Run();
        }














        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
