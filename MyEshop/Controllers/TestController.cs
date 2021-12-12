using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyEshop.Controllers
{
    public class TestController : Controller
    {
        [Authorize]
        public string Test1()
        {
            return "Test 1";
        }

        [AllowAnonymous]
        public string Test2()
        {
            return "Test 2";
        }
    }
}
