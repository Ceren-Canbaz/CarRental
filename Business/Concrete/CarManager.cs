using Business.Abstract;
using Business.Contants;
using Core.Entities;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
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

		public IResult Add(Car car)
		{
			if (car.Description.Length <= 3)
			{
				return new ErrorResult(Messages.Error);
			}
			_carDal.Add(car);
			return new SuccessResult(Messages.Success);
		}
		public IResult Update(Car car)
		{
			if (car.Description.Length <= 3)
			{
				return new ErrorResult(Messages.Error);
			}
			_carDal.Update(car);
			return new SuccessResult(Messages.Success);
		}

		public IResult Delete(Car car)
		{
			if (car.Description.Length <= 3)
			{
				return new ErrorResult(Messages.Error);
			}
			_carDal.Delete(car);
			return new SuccessResult(Messages.Success);
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
