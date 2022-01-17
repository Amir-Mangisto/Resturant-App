using ResturantUsingMvcEtLts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResturantUsingMvcEtLts.Controllers
{
    public class ChefController : Controller
    {
        List<Chef> chefList = new List<Chef>();
        // GET: Chef
        public ActionResult GetChefName()
        {
            GetListOfChef();
            ViewBag.chefName=chefList[4].FullName;
            return View();
        }


        public ActionResult GetChef(int id)
        {
           Chef os= GetListOfChef().First(x => x.Id == id); 
            ViewBag.Thechef=os;
            return View();
        }
        private List<Chef> GetListOfChef()
        {
            Chef[] chefArray = new Chef[]{
                new Chef(1, "amir mangisto", 27, "mango@mango.com", 5000),
                new Chef(2, "avi admaso", 26, "avi@avi.com", 3500),
                new Chef(3, "oshri tzagay", 25, "oshri@oshri.com", 5000),
                new Chef(4, "Jacob shiber", 23, "ajacob@jacob.com", 3500),
                new Chef(5, "eli Beli", 25, "elibeli@eli.com", 4000)
            };
            chefList.AddRange(chefArray);
            return chefList;
        }
    }
}