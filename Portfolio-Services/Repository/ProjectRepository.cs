using Portfolio_Services.Models;

namespace Portfolio_Services.Repository
{
    public class ProjectRepository:IProjectRepository
    {
        public List<Project> projects { get; private set; }
        public ProjectRepository()
        {

            projects = this.defaultProjects();



        }


        private List<Project> defaultProjects()
        {

            List<Project> projects = new List<Project> {
                        new Project(
                            1,
                            "Registration Information Tracking System (RITS)",
                            "Developed a system to track registration information, ensuring accurate reporting and analysis using Azure Data Factory and Power BI.",
                            new List<string> { "image1.jpg", "image2.jpg" },
                            "https://yourportfolio.com/projects/rits",
                            new List<string> { "Azure Data Factory", "Power BI", "SQL Server Reporting Services" },
                            new List<string> { "Data Analysis", "SQL", "Power BI" },
                            new List<string> { "Improved data processing speed by 30%", "Enhanced reporting accuracy" }
                        ),
                        new Project(
                            2,
                            "In Person Payment Solution (IPS)",
                            "Migrated a legacy Java EE application to a modern system using Angular and Spring Boot, improving user experience and system performance.",
                            new List<string> { "image3.jpg", "image4.jpg" },
                            "https://yourportfolio.com/projects/ips",
                            new List<string> { "Angular", "Spring Boot", "REST APIs" },
                            new List<string> { "Java", "Angular", "Spring Boot" },
                            new List<string> { "Reduced load times by 25%", "Achieved a 40% increase in user satisfaction" }
                        ),
                        new Project(
                            3,
                            "Enterprise Center Reporting (ECR)",
                            "Collaborated on a legacy application to implement new functionalities, enhancing user access control and event management.",
                            new List<string> { "image5.jpg", "image6.jpg" },
                            "https://yourportfolio.com/projects/ecr",
                            new List<string> { "Java EE", "JSP", "Struts" },
                            new List<string> { "Java", "JSP", "Database Design" },
                            new List<string> { "Enhanced event management capabilities", "Improved user access control" }
                        ),
                        new Project(
                            4,
                            "Web Application Migration",
                            "Led the migration of a legacy web application from Java 1.8 to Java 17, implementing Spring Boot and improving performance.",
                            new List<string> { "image7.jpg", "image8.jpg" },
                            "https://yourportfolio.com/projects/webappmigration",
                            new List<string> { "Java 17", "Spring Boot", "Tomcat" },
                            new List<string> { "Java", "Spring Boot", "Microservices" },
                            new List<string> { "Increased application performance by 50%", "Enhanced scalability and maintainability" }
                        ),
                        new Project(
                            5,
                            "Data Engineering with Azure",
                            "Developed data pipelines in Azure Data Factory for transforming and analyzing data, streamlining the reporting process.",
                            new List<string> { "image9.jpg", "image10.jpg" },
                            "https://yourportfolio.com/projects/dataengineering",
                            new List<string> { "Azure Data Factory", "Databricks", "Power BI" },
                            new List<string> { "Data Engineering", "Python", "SQL" },
                            new List<string> { "Automated data transformation processes", "Reduced reporting time by 40%" }
                        )
             };
            return projects;

        }

        public String addProject(Project project)
        {
            string status = "sucess";
            try
            {
                this.projects.Add(project);
            }
            catch (Exception ex)
            {
                status = ex.Message;
            }

            return status;
            
        }

        public string updateProject(string id)
        {
            throw new NotImplementedException();
        }

        public string deleteProject(string id)
        {
            throw new NotImplementedException();
        }

        public Project getProject(string id)
        {
            throw new NotImplementedException();
        }

        public List<Project> getProjects()
        {
           return this.projects;
        }
    }
}
