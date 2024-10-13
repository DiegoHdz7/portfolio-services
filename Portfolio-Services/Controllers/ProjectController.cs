using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Portfolio_Services.Exception_Handling;
using Portfolio_Services.Models;
using Portfolio_Services.Repository;
using Portfolio_Services.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio_Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectRepository projectRepository;


        public ProjectController(IProjectRepository projectRepository) { 
            this.projectRepository = projectRepository;
        }

        // GET: api/<ProjectsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("/listAll")]
        public string Get(int id)
        {

            return "rojectRepository";
        }

        [HttpGet("/all-projects")]
        public ActionResult<GenericHttpResponse<List<Project>>> GetAllProjects()
        {
            GenericHttpResponse<List<Project>> response = new GenericHttpResponse<List<Project>>();
            response.status = 200;
            response.httpStatusCode = System.Net.HttpStatusCode.OK;
            response.message = "All Projects";
            response.payload = this.projectRepository.getProjects();

            throw new IOException("TEST");


            return Ok(response);

        }


    }
}
