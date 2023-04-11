using System.Collections.Generic;
using WesterosElections.MyModels;

namespace WesterosElections.MyServices
{
    public interface IMyDataActions
    {
        //Tribe table
        int AddNewTribe(string name);
        int UpdateTheVote();
        List<Tribe> GetAllTribesResult();
        int GetVoteByTribe(string name);
        int DeleteTribe(string name);

        
        //Regions Table
        int AddNewRegion(string name);
        int UpdateTheRegion();
        List<Region> GetAllRegionsResult();
        List<Tribe> GetVoteByRegion(string name);
        int DeleteRegion(string name);

    }
}
