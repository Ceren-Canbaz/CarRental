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
	public class EfRentalDal:EfEntityRepositoryBase<Rental,CarRentalContext>,IRentalDal
	{
		public List<RentalDetailsDto> GetRentalDetails()
		{
			using (CarRentalContext context=new CarRentalContext())
			{
				var result = from r in context.Rentals
							 join c in context.Cars
							 on r.CarId equals c.Id
							 join cu in context.Customers
							 on r.CustomerId equals cu.Id
							 select new RentalDetailsDto
							 {
								 RentalId=r.Id,
								 CarId=c.Id,
								 CarName=c.Name,
								 CustomerId=cu.Id,
								 CustomerName=cu.CompanyName,
								 RentDate=r.RentDate,
								 ReturnDate=r.ReturnDate
								 
							 };
				return result.ToList();
			}
				 
		}
	}
}
