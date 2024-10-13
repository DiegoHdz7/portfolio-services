
namespace Portfolio_Services.Models
{
    public class Project
    {
        private int id;
        public string? name {  get;  private set; }
        public string? description { get; private set; }
        public List<string>? images { get; private set; }
        public string? link { get; private set; }
        public List<string>? technologies { get; private set; }
        public  List<string>? skills { get; private set; }
        public List<string>? achievements { get; private set; }

        public Project(int id,string name, string description, List<string> images, string link, List<string> technologies, List<string> skills, List<string> achievements)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.images = images;
            this.link = link;
            this.technologies = technologies;
            this.skills = skills;
            this.achievements = achievements;
        }

        public Project() { }



       
    }
}
