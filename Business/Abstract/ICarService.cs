using Core.Utilities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<Car> GetAll();
		Car Get(int id);
		List<Car> GetAllByBrand(int brandId);
		List<CarDetailDto> GetCarDetail();
		IResult Add(Car car);
		IResult Update(Car car);
		IResult Delete(Car car);


	}
}
