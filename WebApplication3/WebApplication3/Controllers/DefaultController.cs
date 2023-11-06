using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: Default
      

            public string[] Get()
            {
                return new string[]
                {
                    "Hello",
                    "World"
                };
            }
          
        
    }
}