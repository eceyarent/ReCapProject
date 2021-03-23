using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Business.BusinessAspect.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add,admin")]
        [CacheRemoveAspect("ICarService.Get")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {

            _carDal.Add(car);

            return new ErrorResult(Messages.DescriptionInvalid);

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarsDeleted);
        }

        //[CacheAspect]
        //[PerformanceAspect(6)]
        //[SecuredOperation("car.list,admin")]
        public IDataResult<List<Car>> GetAll()
        {
            Thread.Sleep(1000);
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        [CacheAspect]
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id), Messages.CarsListed);
        }



        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.BrandId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.ColorId == id));
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length >= 2)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.CarsListed);
            }

            return new ErrorResult(Messages.CarError);
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {

            Add(car);
            if (car.DailyPrice < 10)
            {
                throw new Exception("x");
            }

            Add(car);
            return null;
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.Id == id));
        }
    }
}

