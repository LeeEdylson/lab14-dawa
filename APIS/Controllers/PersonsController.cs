using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using API.Models;


namespace API.Controllers
{
    public class PersonsController : Controller
    {
        public List<PersonResponse> Get()
        {
            var result = new List<PersonResponse>();
            for (int i = 0; i < 10; i++)
            {
                result.Add(new PersonResponse {  FullName = "Lee" });
            }
            return result;
        }
        public PersonResponse Insert(PersonRequest request)
        {
            var result = new PersonResponse();
            result.FullName = string.Concat(request.FirstName, request.LastName);
            return result;
        }
    }
}
