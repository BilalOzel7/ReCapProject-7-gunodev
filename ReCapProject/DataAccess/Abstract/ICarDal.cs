using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int Id);
        void Add(Car car);
        void Delte(Car car);
        void Update(Car car);
    }
}
