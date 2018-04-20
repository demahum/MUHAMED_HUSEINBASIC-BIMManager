using BIMManager.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BIMManager.API.Controllers
{
    [Route("api/project")]
    public class ProjectController : Controller
    {

        private readonly ProjectRepository _projectRepository;
        
        public ProjectController(ProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        // GET
        [HttpGet]
        public IActionResult GetAllProjects()
        {
            return Ok(
            new {
                status = true,
                result = _projectRepository.GetAll()
            });
        }
    }
}