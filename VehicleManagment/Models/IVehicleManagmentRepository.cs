using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagment.Models
{
    //generic interface to intaract with any vehicle  IVehicleManagmentRepository
    public interface IVehicleManagmentRepository<TEntity> where TEntity : class
    {
        void Add(TEntity item);
        List<TEntity> GetInventoryList();
    }

    
}
