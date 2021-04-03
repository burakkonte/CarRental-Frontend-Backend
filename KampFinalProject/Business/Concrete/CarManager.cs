using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length<2&&car.DailyPrice<0)
            {
                Console.WriteLine("Gerekli gereksimleri karşılamıyorsunuz.");

            }
        }

        public void GetAll()
        {
            _carDal.GetAll();
        }

       
        

        public void GetById(int carId)
        {
            _carDal.Get(c => c.CarId == carId);
        }

        public void GetByUnitPrice(int dailyPrice)
        {
            _carDal.Get(c=>c.DailyPrice == dailyPrice );
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public void Update(Car car)
        {
            _carDal.Update(car);

        }
    }
}
