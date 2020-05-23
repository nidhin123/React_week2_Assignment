using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        // GET: api/Contact
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            IList<Contact> contactlist = new List<Contact>() {
                new Contact(){ Name="Nidhin",Address="Piravom",Email="nvarghese@suyati.com"},
                new Contact(){ Name="Sarath",Address="Kochi",Email="sarath@suyati.com"},
                new Contact(){ Name="Raju",Address="Aluva",Email="raju@suyati.com"},
                new Contact(){ Name="Shibin",Address="Kannur",Email="shibin@suyati.com"}
            };
            return contactlist.ToArray();
        }


    }
}
