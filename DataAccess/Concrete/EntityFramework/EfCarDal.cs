using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                           join b in context.Brands
                           on c.BrandId equals b.Id
                           join r in context.Colors
                           on c.ColorId equals r.Id
                      select new CarDetailDto
                    {
                        Id = c.Id,
                        BrandName = b.BrandName,
                        ColorName = r.ColorName,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description
                    };
                return result.ToList();
            }
        }
    }
}
