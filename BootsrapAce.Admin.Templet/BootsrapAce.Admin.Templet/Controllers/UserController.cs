using BootsrapAce.Admin.Templet.Common;
using BootsrapAce.Admin.Templet.Extension.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootsrapAce.Admin.Templet.Controllers
{
    
    public class UserController : BaseController
    {
        //
        // GET: /User/
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditInfo()
        {
            return View();
        }

    }
}
