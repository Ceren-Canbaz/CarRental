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
	public class CustomerManager : ICustomerService
	{
		ICustomerDal _customerDal;

		public CustomerManager(ICustomerDal customerDal)
		{
			_customerDal = customerDal;
		}

		public IResult Add(Customer customer)
		{
			if (customer.CompanyName==null)
			{
				return new ErrorResult(Messages.Error);
			}
			_customerDal.Add(customer);

			return new SuccessResult(Messages.Success);
		}

		public IResult Delete(Customer customer)
		{
			if (customer.Id==0)
			{
				return new ErrorResult(Messages.Error);
			}
			_customerDal.Delete(customer);

			return new SuccessResult(Messages.Success);
		}

		public IDataResult<List<Customer>> GetAll()
		{
			if (DateTime.Now.Hour == 22)
			{
				return new ErrorDataResult<List<Customer>>(Messages.Error);
			}
			_customerDal.GetAll();
			return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.Success);
		}

		public IDataResult<Customer> GetById(int id)
		{
			return new SuccessDataResult<Customer>(_customerDal.Get(c=>c.Id==id),Messages.Success);
		}

		public IResult Update(Customer customer)
		{
			if (customer.CompanyName == null)
			{
				return new ErrorResult(Messages.Error);
			}
			_customerDal.Update(customer);

			return new SuccessResult(Messages.Success);
		}
	}
}
