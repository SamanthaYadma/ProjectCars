using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleManagment.Models
{
    public class CarRepository : IVehicleManagmentRepository<Car>
    {
        public List<Car> carRepo = new List<Car>(){
        new Car{
            Id = 1,
            BodyType = "Sedan",
            Doors =4,
            NoOfWheels=4,
            common =new Common(){Engine="V6",Make="Honda",Model="Accord"}
        },
       new Car{
            Id = 1,
            BodyType = "Sedan",
            Doors =4,
            NoOfWheels=4,
            common =new Common(){Engine="V4",Make="Honda",Model="Civic"}
        }
    };

       

        public List<Car> GetInventoryList()
        {
            return carRepo;
        }

        public void Add(Car item)
        {
            carRepo.Add(item);
            //throw new NotImplementedException();
        }
    }
}