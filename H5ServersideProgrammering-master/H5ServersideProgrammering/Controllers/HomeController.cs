using H5ServersideProgrammering.Areas.Identity.Codes;
using H5ServersideProgrammering.Codes;
using H5ServersideProgrammering.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace H5ServersideProgrammering.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HashingExample _hashingExample;
        private readonly IServiceProvider _serviceProvider;
        private readonly MyUserRoleHandler _myUserRoleHandler;
        private readonly IDataProtector _dataProtector;
        private readonly Crytp _crytpExample;

        public HomeController(
            ILogger<HomeController> logger,
            HashingExample hashingExample,
            IServiceProvider serviceProvider,
            MyUserRoleHandler myUserRoleHandler,
            IDataProtectionProvider dataProtector,
            Crytp crytpExample)
        {
            _logger = logger;
            _hashingExample = hashingExample;
            _serviceProvider = serviceProvider;
            _myUserRoleHandler = myUserRoleHandler;
            _crytpExample = crytpExample;
            _dataProtector = dataProtector.CreateProtector("MyProject.MyClass.SomeUniqName");
        }

        [Authorize("RequireAuthenticatedUser")]
        public IActionResult Index()
        {

            var userName = User.Identity.Name;
            

            IndexModel myModel = new IndexModel() { user = userName };

            return View(model: myModel);
        }

        [Authorize(Policy = "RequireAdminUser")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


}
