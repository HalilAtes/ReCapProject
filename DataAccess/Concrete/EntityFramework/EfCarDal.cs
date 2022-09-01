using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result1 = from p in context.Cars
                              join c in context.Brands
                              on p.BrandId equals c.BrandId
                              select new CarDetailDto
                              {
                                  Id = p.Id,
                                  CarName = p.CarName,
                                  BrandName = c.BrandName,
                                  ModelYear = p.ModelYear
                              };
                return result1.ToList();    // Döngü listelendi.
            }
        }
    }
}
