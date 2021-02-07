using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { Id = 5, BrandId = 3, ColorId = 2, Description = "B", DailyPrice = 100, ModelYear = 2020 });
            

            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Id = 2, ColorName = "mavi" });
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Id = 3, BrandName = "Toyota" });

            //carManager.Add(new Car { Id = 1, BrandId = 3, ColorId = 2, Description = "BMW", DailyPrice = 100, ModelYear = 2020 });
            //carManager.Add(new Car { Id = 2, BrandId = 3, ColorId = 2, Description = "Mercedes", DailyPrice = 100, ModelYear = 2020 });
            carManager.Add(new Car { Id = 2, BrandId = 3, ColorId = 2, Description = "Mercedes", DailyPrice = 100, ModelYear = 2020 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
