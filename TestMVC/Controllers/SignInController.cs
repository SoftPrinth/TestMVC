using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVC.Controllers
{
    public class SignInController : Controller
    {
        //
        // GET: /SignIn/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            string user = Request.Params["userTxt"].ToString();
            string pwd = Request.Params["pwdTxt"].ToString();
            int userType = Int32.Parse(Request.Params["userType"].ToString());

            System.Diagnostics.Debug.WriteLine("User : "+user+" Password : "+pwd+" User Type : "+userType);

            return Redirect("Index");
        }
    }
}
