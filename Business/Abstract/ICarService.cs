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
		void Add(Car car);
		void Update(Car car);
		void Delete(Car car);


	}
}
