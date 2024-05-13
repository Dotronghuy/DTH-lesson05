using dth_lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dth_lesson04.Controllers
{
    public class dthCusstomerSccafingController : Controller
    {
        private static List<dthCustomes> listCutomer = new List<dthCustomes>()
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
        // GET: dthCusstomerSccafing
        public ActionResult Index()
        {
            return View(listCutomer);
        }
        public ActionResult dthCreate()
        {
            var model = new dthCustomes();
            return View();
        }
        [HttpPost]
        public ActionResult dthCreate(dthCustomes model)
        {
            //Thêm mới đối tượng khách hàng vào ds dữ liệu
            listCutomer.Add(model);
            //return View();
            //chuyển về trang danh sách
            return RedirectToAction("Index");
        }
        public ActionResult dthEdit(int id)
        {
            var customer = listCutomer.FirstOrDefault(x => x.Customerid == id);
            return View(customer);
        }
        public ActionResult dthDetails(int id)
        {
            var customer = listCutomer.FirstOrDefault(s => s.Customerid == id);
            return View(customer);
        }
    }
  }