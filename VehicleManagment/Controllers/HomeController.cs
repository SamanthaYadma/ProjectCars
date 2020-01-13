using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleManagment.Models;

namespace VehicleManagment.Controllers
{
    public class HomeController : Controller
    {
        private IVehicleManagmentRepository<Car> repository = null;
        private IEnumerable<VehicleType> _vehicleTypeList = new List<VehicleType>() { new VehicleType{ID =1,Description="Car"}};
        

        public HomeController()  
        {  
           this.repository = new CarRepository();
           ViewBag.ListVehType = _vehicleTypeList;
           ViewBag.ListVehType = new SelectList(_vehicleTypeList, "Id", "Description").ToList();
           


        }

        public HomeController(IVehicleManagmentRepository<Car> repository)  
        {  
           this.repository = repository;  
        }
        

        public ActionResult Home()
        {
            List<Car> cars;
            if (Session["VehicleList"] == null)
            {
               cars = repository.GetInventoryList();
               Session["VehicleList"] = cars;
            }
            else
            {
               cars = Session["VehicleList"] as List<Car>; ;
            }
            return View(cars);
        }

    
        public ActionResult Create()
        {
            return View();
        }
        
         [HttpPost]
         public ActionResult Create(Car ObjCar)
         {
             try
             {
                 if (ModelState.IsValid)
                 {
                     repository.Add(ObjCar);
                     var CarsList = (List<Car>)Session["VehicleList"];
                    CarsList.Add(ObjCar);
                    Session["VehicleList"] = CarsList;
                   
                 }
                 return View();
             }
             catch
             {
                 return View();
             }
         }
       
     
    }
}
