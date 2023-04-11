using System.Collections.Generic;
using System.Linq;
using WesterosElections.DataAccess;
using WesterosElections.MyModels;

namespace WesterosElections.MyServices
{
    public class MyDataActions : IMyDataActions
    {
        private readonly MyDbContext db;
        public MyDataActions(MyDbContext db)
        {
            this.db = db;
        }


        public int AddNewRegion(string name)
        {
            this.db.Regions.Add(new Region { RegionName = name });
            return db.SaveChanges();
        }

        public int AddNewTribe(string name)
        {
            this.db.Tribes.Add(new Tribe { Name = name });
            return db.SaveChanges();
        }

        public int DeleteRegion(string name)
        {
            var regionToRemove = this.db.Regions.FirstOrDefault(x => x.RegionName == name);
            if (regionToRemove == null)
            {
                return 0;
            }
            this.db.Regions.Remove(regionToRemove);
            return db.SaveChanges();
        }

        public int DeleteTribe(string name)
        {
            var tribeToRemove = this.db.Tribes.FirstOrDefault(x => x.Name == name);
            if (tribeToRemove == null)
            {
                return 0;
            }
            this.db.Tribes.Remove(tribeToRemove);
            return db.SaveChanges();
        }

        public List<Region> GetAllRegionsResult()
        {
            return this.db.Regions.ToList();
        }

        public List<Tribe> GetAllTribesResult()
        {
            return this.db.Tribes.ToList();
        }

        public List<Tribe> GetVoteByRegion(string name)
        {
            return this.db.Regions.FirstOrDefault(x => x.RegionName == name)?.AllTribes;
        }

        public int GetVoteByTribe(string name)
        {
            return (int)(this.db.Tribes.FirstOrDefault(x => x.Name == name)?.Vote);
        }

        public int UpdateTheRegion()
        {
            throw new System.NotImplementedException();
        }

        public int UpdateTheVote()
        {
            throw new System.NotImplementedException();
        }
    }
}
