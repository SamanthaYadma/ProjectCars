using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VehicleManagment.Models
{
    public class VehicleType
    {
           public int ID{get;set;}
           public string Description{get;set;}
    }

    public class Common
    {
        //[Display(Name = "Vehicle Type")]
        //[Required(ErrorMessage = "Vehcile Type is required.")]
        //public string VehicleType { get; set; }
        [Display(Name = "Make")]
        [Required(ErrorMessage = "Make is required.")]
        public String Make { get; set; }
        [Display(Name = "Model")]
        [Required(ErrorMessage = "Model is required.")]
        public String Model { get; set; }
        [Display(Name = "Engine")]
        [Required(ErrorMessage = "Engine is required.")]
        public string Engine { get; set; }
    }
}