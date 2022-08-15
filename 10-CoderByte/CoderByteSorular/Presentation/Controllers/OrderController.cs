using BLL.EntityTypeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    [Authorize(Roles = "admin")]
    public class OrderController : Controller
    {
        OrderDetailService orderDetailService = new OrderDetailService();
        public ActionResult Index()
        {
            return View(orderDetailService.GetList());
        }
    }
}