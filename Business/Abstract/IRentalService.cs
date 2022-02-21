using Core.Utilities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IRentalService
	{
		IDataResult<List<Rental>> GetAll();
		IResult Add(Rental Rental);
		IResult Update(Rental rental);
		IResult Delete(Rental rental);
		IDataResult<Rental> GetById(int id);
	}
}
