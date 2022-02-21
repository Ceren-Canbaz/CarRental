using Business.Abstract;
using Business.Contants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class BrandManager : IBrandService
	{
		IBrandDal _brandDal;

		public BrandManager(IBrandDal brandDal)
		{
			_brandDal = brandDal;
		}

		public IResult Add(Brand brand)
		{
			if (brand.Name.Length<2)
			{
				return new ErrorResult(); //yalnizca false bilgisi dönecektir
			}

			_brandDal.Add(brand);
			return new SuccessResult(Messages.Success); //mesaj bilgisi de dönecektir
		}

		public IResult Delete(Brand brand)
		{
			if (brand.Name.Length < 2)
			{
				return new ErrorResult(Messages.Error); 
			}
			_brandDal.Delete(brand);
			return new SuccessResult(Messages.Success); 
		}

		public IDataResult<List<Brand>> GetAll()
		{
			if (DateTime.Now.Hour == 22)
			{
				return new ErrorDataResult<List<Brand>>(Messages.Error);
			}
			//mesajsız constructora gidecektir			//data , true
			return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
		}

		public IResult Update(Brand brand)
		{
			if (brand.Name.Length < 2)
			{
				return new ErrorResult(Messages.Error);
			}
			_brandDal.Update(brand);
			return new SuccessResult(Messages.Success);
		
		}
	}
}
