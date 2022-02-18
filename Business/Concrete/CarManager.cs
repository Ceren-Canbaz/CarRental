using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarDal _carDal;

		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public void Add(Car car)
		{
			_carDal.Add(car);
		}
		public void Update(Car car)
		{
			_carDal.Update(car);
		}

		public void Delete(Car car)
		{
			_carDal.Delete(car);
		}

		public Car Get(int id)
		{
			return _carDal.Get(c => c.Id ==id);
		}

		public List<Car> GetAll()
		{
			return _carDal.GetAll();
		}

		public List<Car> GetAllByBrand(int brandId)
		{
			return _carDal.GetAll(c => c.BrandId == brandId);
		}

		public List<CarDetailDto> GetCarDetail()
		{
			return _carDal.GetCarDetails();
		}
	}
}
