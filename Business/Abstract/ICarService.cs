using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int id);

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        IDataResult<Car> GetById(int id);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult AddTransactionalTest(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int id); 
    }
}
