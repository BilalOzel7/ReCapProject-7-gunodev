using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1 , ModelYear = 2000 ,DailyPrice = 75000,Description = "Tofaş"},
                new Car{CarId = 2, BrandId = 2, ColorId = 2 , ModelYear = 2009 ,DailyPrice = 75000,Description = "Fiat"},
                new Car{CarId = 3, BrandId = 2, ColorId = 1 , ModelYear = 2020 ,DailyPrice = 75000,Description = "Tesla"},
                new Car{CarId = 4, BrandId = 1, ColorId = 4 , ModelYear = 2018 ,DailyPrice = 75000,Description = "Audi"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delte(Car car)
        {
            Car deleteCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(deleteCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carUpdate.CarId = car.CarId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
    }
}
