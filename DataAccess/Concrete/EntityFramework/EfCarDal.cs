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
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                IQueryable<CarDetailDto> result = from c in filter is null ? context.Cars : context.Cars.Where(filter)
                    join b in context.Brands
                        on c.BrandId equals b.Id
                    join cl in context.Colors
                        on c.ColorId equals cl.Id
                    select new CarDetailDto
                    {
                        Id = c.Id,
                        BrandName = b.BrandName,
                        ColorName = cl.ColorName,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description
                    };
                return result.ToList();
            }
        }
    }
}
