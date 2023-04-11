using System.Collections.Generic;

namespace WesterosElections.MyModels
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public List<Tribe> AllTribes { get; set; }
    }
}
