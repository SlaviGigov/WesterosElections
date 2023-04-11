namespace WesterosElections.MyModels
{
    public class Tribe
    {
        public int TribeId { get; set; } 
        public string Name { get; set; }
        public int Vote { get; set; }
        public bool InOrOut { get; set; }
        public int Deputats {get; set; }

    }
}
