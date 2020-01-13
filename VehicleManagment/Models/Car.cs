using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VehicleManagment.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Display(Name = "Number Of Wheels")]
        [Required(ErrorMessage = "Number of wheels is required.")]
        [RegularExpression("(^[0-9]{1,2}$)", ErrorMessage = "Number of Wheels must be a numeric")]
        public int NoOfWheels { get; set; }
        
        [Display(Name = "Number Of Doors")]
        [Required(ErrorMessage = "Number of doors is required.")]
        [RegularExpression("(^[0-9]{1,2}$)", ErrorMessage = "Doors must be a numeric")]
        public int Doors { get; set; }
        
        [Display(Name = "Body Type")]
        [Required(ErrorMessage = "Body type is required.")]
        public string BodyType { get; set; }
        public Common common { get; set; }
    }
}