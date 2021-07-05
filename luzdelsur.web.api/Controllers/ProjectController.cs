using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using luzdelsur.web.business;
using luzdelsur.web.business.Models;
using Microsoft.AspNetCore.Mvc;

namespace luzdelsur.web.api.Controllers
{
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            BoProject boProject = new BoProject();
            List<ProjectDto> projects = new List<ProjectDto>();
            projects = boProject.GetProjects();
            return new OkObjectResult(projects);
        }
    }
}
