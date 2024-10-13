using Portfolio_Services.Models;

namespace Portfolio_Services.Repository
{
    public interface IProjectRepository
    {
        public String addProject(Project project);
        public String updateProject(string id);
        public String deleteProject(string id);
        public Project getProject(String id);
        public List<Project> getProjects();



    }
}
