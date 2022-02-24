using Business.Abstract;
using Business.Contants;
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
	public class RentalManager : IRentalService
	{
		IRentalDal _rentalDal;

		public RentalManager(IRentalDal rentalDal)
		{
			_rentalDal = rentalDal;
		}

		public IResult Add(Rental rental)
		{
			//true ise kiralanmış anlamına geliyor
			if (rental.RentSituation == true)
			{
				return new ErrorResult(Messages.Error);
			}
			rental.RentSituation = true;
			_rentalDal.Add(rental);
			return new SuccessResult(Messages.Success);
		}

		public IResult Delete(Rental rental)
		{
			_rentalDal.Delete(rental);
			return new SuccessResult(Messages.Success);
		}

		public IDataResult<List<Rental>> GetAll()
		{
			return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
		}

		public IDataResult<Rental> GetById(int id)
		{
			
			return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id),Messages.Success);
		}

		public IDataResult<List<RentalDetailsDto>> GetRentalDetail()
		{
			return new SuccessDataResult<List<RentalDetailsDto>>(_rentalDal.GetRentalDetails());
		}

		public IResult Update(Rental rental)
		{
			_rentalDal.Update(rental);
			return new SuccessResult(Messages.Success);
		}
	}
}
