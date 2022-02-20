using Core.Utilities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IBrandService
	{
		List<Brand> GetAll();
		IResult Add(Brand brand);
		IResult Update(Brand brand);
		IResult Delete(Brand brand);
	}
}
