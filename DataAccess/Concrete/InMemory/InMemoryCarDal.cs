using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;                // Global değişken oluşturup içine listeyi atıcazz bu yüzden list tipinde bir değişken oluşturduk.
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>
        //    {   
        //        new Car {Id=1,CarName="Mustang",BrandId=1,ColorId=1,ModelYear=1995,DailyPrice=100},
        //        new Car {Id=2,CarName="Passat",BrandId=1,ColorId=2,ModelYear=1997,DailyPrice=120},
        //        new Car {Id=3,CarName="Audi",BrandId=2,ColorId=1,ModelYear="1985",DailyPrice=130},
        //        new Car {Id=4,CarName="Maserati",BrandId=2,ColorId=2,ModelYear="1995",DailyPrice=150},
        //        new Car {Id=5,CarName="Volvo",BrandId=3,ColorId=3,ModelYear="1975",DailyPrice=80}

        //    };
        //}

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(CarToDelete);


        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            CarToUpdate.Id = car.Id;
            CarToUpdate.CarName = car.CarName;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;



        }

        //Car IEntityRepository<Car>.GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
