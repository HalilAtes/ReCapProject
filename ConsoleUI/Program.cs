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


            //carManager.Add(new Car { CarName = "xyz", BrandId = 2, ColorId = 2, DailyPrice = 130, Description = "abcd", ModelYear = 2013 });
            //Console.WriteLine("Car Added!");


            Console.WriteLine("------- 0 --------");

            CarDailyPriceTest1();

            Console.WriteLine("------- 1 --------");

            BrandNameTest1();

            Console.WriteLine("------- 2 --------");

            CarDetailTest1(carManager);

            Console.WriteLine("------- 3 --------");

            CarManager carManager3 = new CarManager(new EfCarDal());

            CarDetailTest1(carManager3);

            Console.WriteLine("------- 4 --------");


            //test();


            CarManager carManager1 = new CarManager(new EfCarDal());

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 103,
                ReturnDate = new DateTime(2022, 8, 22),
                RentDate = new DateTime(2021, 4, 10)
            });
            Console.WriteLine("Rental Added");

            Console.WriteLine("------- 5 --------");


            RentalManager rentalManager2 = new RentalManager(new EfRentalDal());
            foreach (var rental in rentalManager2.GetAll().Data)
            {
                Console.WriteLine(rental.RentDate);
            }


        }

        private static void test()
        {
            CarManager carManager1 = new CarManager(new EfCarDal());

            foreach (var car in carManager1.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName);

            }
        }

        private static void CarDetailTest1(CarManager carManager3)
        {

            var result1 = carManager3.GetCarDetails();

            if (result1.Success == true)
            {

                foreach (var car in result1.Data)
                {
                    Console.WriteLine(car.CarName + "      /             " + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result1.Message);
            }

            //foreach (var car in result1.Data)
            //{
            //    Console.WriteLine(car.CarName + "      /               " + car.BrandName);

            //}
        }

      

        private static void BrandNameTest1()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarDailyPriceTest1()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());

            foreach (var car in carManager2.GetByDailyPrice(60, 100).Data)
            {
                Console.WriteLine(car.CarName);

            }
        }
    }
}
