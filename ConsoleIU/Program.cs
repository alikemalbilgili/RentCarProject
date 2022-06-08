

using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using System;

namespace ConsoleIU
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("{0} / {1} / {2} / {3}", car.ModelYear, car.ModelName, car.BrandName, car.ColorName);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.ModelName);

            //}
            Console.ReadLine();
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand);
            //}
        }
    }
}
