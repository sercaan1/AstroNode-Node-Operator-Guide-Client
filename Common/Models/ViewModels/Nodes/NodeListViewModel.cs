namespace Common.Models.ViewModels.Nodes
{
    public class NodeListViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? ReviewRate { get; set; }
        public int? ReviewDifficulty { get; set; }
    }
}
