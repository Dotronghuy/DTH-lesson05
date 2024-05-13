using dth_lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dth_lesson04.Controllers
{
    public class DthCustomesController : Controller
    {
        // GET: DthCustomes
        public ActionResult Index()
        {
            return View();
        }
        //action : customesdeatail
        public ActionResult Dthcustomesdeatail()
        {
            //tạo đối tượng dữ liệu
            var customer = new dthCustomes()
            {
                Customerid = 1,
                FirstName = "Đỗ Trọng",
                LastName = "Huy",
                YearOfBirtday = "2004",
                adderrs = "hel0babyno1234@gmail.com"
            };
            ViewBag.customer = customer;

            return View();

        }
        // get: listcustomes
        public ActionResult DthListCustomer()
        {
            var list = new List<dthCustomes>()
            {
                new dthCustomes()
                {
                     Customerid = 1,
                        FirstName = "Đỗ Trọng",
                        LastName = "Huy",
                        YearOfBirtday = "2004",
                        adderrs = "K22CNT1"
                },
                   new dthCustomes()
                {
                     Customerid = 2,
                        FirstName = "Nguyễn Văn",
                        LastName = "Thạo",
                        YearOfBirtday = "2004",
                        adderrs = "K22CNT1"
                },
                          new dthCustomes()
                {
                     Customerid = 3,
                        FirstName = "Nguyễn Văn",
                        LastName = "Huy",
                        YearOfBirtday = "2004",
                        adderrs = "K22CNT1"
                },
                       new dthCustomes()
                {
                     Customerid = 4,
                        FirstName = "Nguyễn Văn",
                        LastName = "Thảo",
                        YearOfBirtday = "2004",
                        adderrs = "K22CNT1"
                },

            };
            ViewBag.list = list;

            return View();

        }
    }
}