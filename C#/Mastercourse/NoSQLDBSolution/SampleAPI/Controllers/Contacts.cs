using DataAccesLibrary;
using DataAccesLibrary.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Contacts : ControllerBase
    {
        private MongoDBDataAccess db;
        private readonly string tableName = "Contacts";
        private readonly IConfiguration _config;

        public Contacts(IConfiguration config)
        {
            _config = config;
            db = new MongoDBDataAccess("MongoContactsDB", _config.GetConnectionString("Default"));
        }

        [HttpGet]
        public List<ContactModel> GetAll()
        {
            return db.LoadRecords<ContactModel>(tableName);
        }

        [HttpPost]
        public void InsertRecord(ContactModel contact)
        {
            db.UpsertRecord(tableName, contact.Id, contact);
        }

        // GET api/<Contacts>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // PUT api/<Contacts>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Contacts>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
