using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
	{
		public List<CarDetailDto> GetCarDetails()
			
		{
			using (CarRentalContext context= new CarRentalContext())
			{
				var result = from c in context.Cars
							 join b in context.Brands
							 on c.BrandId equals b.Id
							 join co in context.Colors
							 on c.ColorId equals co.Id
							 select new CarDetailDto
							 {
								 CarId = c.Id,
								 CarName = c.Name,
								 Description = c.Description,
								 BrandName = b.Name,
								 ColorName = co.Name,
								 UnitPrice = c.DailyPrice

							 };
				return result.ToList();

			}
		}
	}
}
