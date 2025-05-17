using APIHomework.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIHomework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonInformationController : ControllerBase
    {
        private ILogger _logger;

        public PersonInformationController(ILogger<PersonInformationController> logger)
        {
            _logger = logger;
        }

        // POST api/<PersonInformationController>
        //[HttpPost]
        //public void Post([FromBody] PersonModel person)
        //{
        //    _logger.LogInformation("The person was logged as {Person}", person);
        //}

        // POST api/<PersonInformationController>
        [HttpPost]
        public void Post([FromBody] AddressModel address)
        {
            _logger.LogInformation("The person was logged as {Address}", address);
        }
    }
}
