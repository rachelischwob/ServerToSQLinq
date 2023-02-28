using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Services;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IFiles filesServer;

        public HomeController(IFiles filesServer)
        {
            this.filesServer = filesServer;
        }


        // GET: api/<HomeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HomeController>
        [HttpPost]
        public IEnumerable<Person> ImportExcel(IFormFile uploadedFile)
        {
            if (CheckIfExcelFile(uploadedFile))
            { List<Person> people = filesServer.readFromExelFile(uploadedFile); }
            return filesServer.CheckValidExcel(new List<Person>());
        }
        private bool CheckIfExcelFile(IFormFile file)
        {
            var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
            return (extension == ".xlsx" || extension == ".xls");
        }
        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
