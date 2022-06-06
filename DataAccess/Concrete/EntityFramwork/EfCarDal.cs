using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarDbContext>,ICarDal
    {
        public List<CarDetailDTos> GetCarDetails()
        {
           
            using (RentCarDbContext context = new RentCarDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDTos
                             {
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName,
                                 ModelYear =c.ModelYear,
                                 ModelName=c.ModelName,
                                 PricePerHour=c.PricePerHour,
                             };
                return result.ToList();
            }
        }
    }
}
