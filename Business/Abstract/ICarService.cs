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
		IDataResult<List<Car>> GetAll();
		IDataResult<Car> Get(int id);
		IDataResult<List<Car>> GetAllByBrand(int brandId);
		IDataResult<List<CarDetailDto>> GetCarDetail();
		IResult Add(Car car);
		IResult Update(Car car);
		IResult Delete(Car car);


	}
}
