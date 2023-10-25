using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai1.Models
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        /*
         thực hiện gán giá trị của
        các control trên form vào biến đối tượng Session, sau đó trả về trang
        MHXacNhan.cshtml.
         */

        public ActionResult Index(string txt_FullName, string txt_ID, string txt_Email, string File_Image, string t_Note, bool Chk1, bool Chk2, bool Chk3)
        {
            Session["info"] = new Information()
            {
                FullName = txt_FullName,
                IdStudent = txt_ID,
                Email = txt_Email,
                FileImage = File_Image,
                Note = t_Note,
                Check1 = Chk1,
                Check2 = Chk2,
                Check3 = Chk3
            };
            return RedirectToAction("MHXacNhan", "Home");
        }

        public ActionResult MHXacNhan()
        {
            return View();
        }
	}
}
