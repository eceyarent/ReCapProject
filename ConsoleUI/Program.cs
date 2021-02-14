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
            //CarTest();

            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.Description+"/"+car.BrandName+"/"+car.ColorName+"/"+car.DailyPrice);
            //}

            //Odev10DersTest();
        }

        private static void Odev10DersTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { Id = 1, FirstName = "Ece", LastName = "Yaren", Email = "ece@gmail.com", Password = 1234 });
            userManager.Add(new User { Id = 2, FirstName = "Hasan", LastName = "Çifçi", Email = "hasan@gmail.com", Password = 4567 });
            userManager.Add(new User { Id = 3, FirstName = "Osman", LastName = "Korkmaz", Email = "osman@gmail.com", Password = 6789 });


            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { Id = 1, UserId = 1, CompanyName = "Mercedes Benz" });
            customerManager.Add(new Customer { Id = 2, UserId = 2, CompanyName = "BMW" });
            customerManager.Add(new Customer { Id = 3, UserId = 3, CompanyName = "Ford" });

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { Id = 1, CarId = 1, CustomerId = 1, RentDate = new DateTime(2020, 02, 15), ReturnDate = new DateTime(2020, 03, 23) });
            rentalManager.Add(new Rental { Id = 2, CarId = 1, CustomerId = 2, RentDate = new DateTime(2020, 02, 16), ReturnDate = new DateTime(2020, 03, 22) });
            rentalManager.Add(new Rental { Id = 3, CarId = 1, CustomerId = 3, RentDate = new DateTime(2020, 02, 17), ReturnDate = new DateTime(2020, 03, 21) });
        }

        private static void CarTest()
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            ////carManager.Add(new Car { Id = 5, BrandId = 3, ColorId = 2, Description = "B", DailyPrice = 100, ModelYear = 2020 });


            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { Id = 2, ColorName = "mavi" });
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { Id = 3, BrandName = "Toyota" });

            ////carManager.Add(new Car { Id = 1, BrandId = 3, ColorId = 2, Description = "BMW", DailyPrice = 100, ModelYear = 2020 });
            ////carManager.Add(new Car { Id = 2, BrandId = 3, ColorId = 2, Description = "Mercedes", DailyPrice = 100, ModelYear = 2020 });
            //carManager.Add(new Car { Id = 2, BrandId = 3, ColorId = 2, Description = "Mercedes", DailyPrice = 100, ModelYear = 2020 });

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            


        }
    }
}
