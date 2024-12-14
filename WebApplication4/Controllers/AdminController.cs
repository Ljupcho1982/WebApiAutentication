using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
        public class AdminController : ControllerBase
        {
            [HttpGet]
            public IActionResult Get()
            {
                return Ok("You have accessed the Admin controller.");
            }
        }

    }

