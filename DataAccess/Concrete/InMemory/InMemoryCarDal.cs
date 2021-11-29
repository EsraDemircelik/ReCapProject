using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{  CarId=1,BrandId=1,ColorId=1,ModelYear=2017,DailyPrice=150000,Description="Dizel"},
                new Car{  CarId=2,BrandId=2,ColorId=2,ModelYear=2019,DailyPrice=500000,Description="Benzin"},
                new Car{  CarId=3,BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=135000,Description="LPG"},
                new Car{  CarId=4,BrandId=3,ColorId=3,ModelYear=2020,DailyPrice=550000,Description="Benzin"},
                new Car{  CarId=5,BrandId=1,ColorId=2,ModelYear=2016,DailyPrice=190000,Description="Dizel"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetId(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public List<Car> GetId()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
