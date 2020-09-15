using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace FruitManager.Controllers
{
    public class FruitsController : ApiController
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            Console.WriteLine("Base Controller initialized");
            base.Initialize(controllerContext);
        }
        protected override void Dispose(bool disposing)
        {
            Console.WriteLine("Base Controller Disposed");
            base.Dispose(disposing);
        }
    }
}
