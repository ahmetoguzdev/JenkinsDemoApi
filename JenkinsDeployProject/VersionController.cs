using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsDeployProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        public IConfiguration Configuration;

        public VersionController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
