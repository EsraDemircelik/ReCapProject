using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }
            foreach(var car in carManager.GetAll())
            {
                Console.WriteLine(car.ColorId + " renkli " + car.BrandId +" marka aracın " +
                                  car.DailyPrice + " günlük fiyatılı araç" );
            }
        }
    }
}
