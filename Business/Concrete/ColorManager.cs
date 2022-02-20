using Business.Abstract;
using Business.Contants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class ColorManager : IColorService
	{
		IColorDal _colorDal;

		public ColorManager(IColorDal colorDal)
		{
			_colorDal = colorDal;
		}

		public IResult Add(Color color)
		{
			if (color.Name.Length < 2)
			{
				return new ErrorResult(Messages.Error);
			}
			_colorDal.Add(color);
			return new SuccessResult(Messages.Success);
		}

		public IResult Delete(Color color)
		{
			if (color.Name.Length < 2)
			{
				return new ErrorResult(Messages.Error);
			}
			_colorDal.Delete(color);
			return new SuccessResult(Messages.Success);
		}

		public List<Color> GetAll()
		{
			return _colorDal.GetAll();
		}

		public IResult Update(Color color)
		{
			if (color.Name.Length < 2)
			{
				return new ErrorResult(Messages.Error);
			}
			_colorDal.Update(color);
			return new SuccessResult(Messages.Success);
		}
	}
}
