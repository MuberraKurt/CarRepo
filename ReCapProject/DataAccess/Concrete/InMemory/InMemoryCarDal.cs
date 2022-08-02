using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId="1",BrandId="1",ColorId="1",DailyPrice=5,Description="a",ModelYear=1},
                new Car{CarId="2",BrandId="2",ColorId="2",DailyPrice=58,Description="ab",ModelYear=1},
                new Car{CarId="3",BrandId="2",ColorId="3",DailyPrice=55,Description="as",ModelYear=1},
                new Car{CarId="4",BrandId="3",ColorId="5",DailyPrice=50,Description="ad",ModelYear=6},
                new Car{CarId="5",BrandId="3",ColorId="4",DailyPrice=54,Description="afd",ModelYear=5}
            };
        }
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(x => x.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(string carId)
        {
            return _cars.Where(p=>p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
            carToUpdate.ModelYear=car.ModelYear;
        }
    }
}
