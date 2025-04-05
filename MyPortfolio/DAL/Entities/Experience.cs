namespace MyPortfolio.DAL.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ImageAlt { get; set; }
        public string Date { get; set; }
    }
}