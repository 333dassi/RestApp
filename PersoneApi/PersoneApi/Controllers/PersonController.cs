using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersoneApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        Person person = new Person("22344453", "Dassi", "0506778345", 21);

        [HttpGet]
        public string Get()
        {
            person.printTofile();
            return person.ToString();
        }

        [HttpPost("add/{gender}/{email}")]
        public void Post(string gender,string email)
        {
            UpdatePerson uPersone = new UpdatePerson(person.ID, person.Name, person.Phone, person.Age, gender, email);
            uPersone.printTofile();
        }
        

    }
}
