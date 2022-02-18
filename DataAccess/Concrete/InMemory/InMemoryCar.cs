using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCar : ICarDal
	{
		List<Car> _cars;

		public InMemoryCar()
		{
			_cars = new List<Car>
			{
				new Car{Id=1,BrandId=2,ColorId=5,DailyPrice=5000,Description="Volvo",ModelYear=2002},
				new Car{Id=2,BrandId=3,ColorId=2,DailyPrice=10500,Description="Audi",ModelYear=2005},
				new Car{Id=3,BrandId=5,ColorId=6,DailyPrice=20000,Description="BMW",ModelYear=2010}
			};
		}

		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car carToDelete = null;
			carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
			_cars.Remove(carToDelete);
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

		public Car GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<CarDetailDto> GetCarDetails()
		{
			throw new NotImplementedException();
		}

		public void Update(Car car)
		{
			throw new NotImplementedException();
		}
	}
}
