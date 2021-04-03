using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void GetAll();
       
        void GetByUnitPrice(int dailyPrice);
        IDataResult<List<CarDetailDto>> GetCarDetails();

        void GetById(int carId);
        void Add(Car car);
        void Update(Car car);
        

    }
}
