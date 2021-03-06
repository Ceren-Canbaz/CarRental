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
	public class UserManager : IUserService
	{
		IUserDal _userDal;

		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public IResult Add(User user)
		{
			_userDal.Add(user);
			return new SuccessResult(Messages.Success);
		}

		public IResult Delete(User user)
		{
			_userDal.Delete(user);
			return new SuccessResult(Messages.Success);
		}

		public IDataResult<List<User>> GetAll()
		{
			return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.Success);
		}

		public IDataResult<User> GetById(int id)
		{
			return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id),Messages.Success);
		}

		public IResult Update(User user)
		{
			_userDal.Update(user);
			return new SuccessResult(Messages.Success);
		}
	}
}
