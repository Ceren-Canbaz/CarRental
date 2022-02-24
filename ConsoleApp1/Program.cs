using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;
using Entities.Concrete;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//CarTest();
			//CarDtoTest();
			//CarAddTest();
			//CarUpdateTest();
			//CarDeleteTest();
			//ColorTest();
			//BrandTest();
			//RentAddTest();
			//CustomerAddTest();
			//RentalDetailDto();

		}

		private static void RentalDetailDto()
		{
			RentalManager rentalManager = new RentalManager(new EfRentalDal());
			var result = rentalManager.GetRentalDetail().Data;
			foreach (var rental in result)
			{
				Console.WriteLine(rental.RentalId);
				Console.WriteLine(rental.CarId);
				Console.WriteLine(rental.CarName);
				Console.WriteLine(rental.CustomerId);
				Console.WriteLine(rental.CustomerName);
				Console.WriteLine(rental.RentDate);
				Console.WriteLine(rental.ReturnDate);
			}
		}

		private static void CustomerAddTest()
		{
			CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
			Customer customer = new Customer
			{
				CompanyName = "Canmaksan"
			};
			customerManager.Add(customer);
		}

		private static void RentAddTest()
		{
			RentalManager rentalManager = new RentalManager(new EfRentalDal());
			Rental rental = new Rental
			{
				CarId = 3,
				CustomerId = 1,
				RentDate = DateTime.Now,

			};
			rentalManager.Add(rental);
		}

		private static void CarDeleteTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			Car newcar = new Car();
			newcar.Id = 5;
			carManager.Delete(newcar);
			CarDtoTest();
		}

		private static void CarUpdateTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			Car updatedCar = new Car();
			var result = carManager.Get(5);
			updatedCar = result.Data;
			updatedCar.Name = "Jazz";
			carManager.Update(updatedCar);
			CarDtoTest();
		}

		private static void CarAddTest()
		{
			Car newcar = new Car { Name = "Sideswipe", BrandId = 1, ColorId = 3, DailyPrice = 5500, Description = "Trip Car", ModelYear = 2015 };
			CarManager carManager = new CarManager(new EfCarDal());
			carManager.Add(newcar);
			CarDtoTest();
		}

		private static void CarDtoTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			var result = carManager.GetCarDetail();
			foreach (var car in result.Data)
			{
				Console.WriteLine(car.CarId);
				Console.WriteLine(car.CarName);
				Console.WriteLine(car.BrandName);
				Console.WriteLine(car.ColorName);
				Console.WriteLine(car.Description);
				Console.WriteLine(car.UnitPrice);
				Console.WriteLine("");
			}
		}

		private static void BrandTest()
		{
			BrandManager brandManager = new BrandManager(new EfBrandDal());
			var result = brandManager.GetAll();
			foreach (var brand in result.Data )
			{
				Console.WriteLine(brand.Name);
			}
		}

		private static void ColorTest()
		{
			ColorManager colorManager = new ColorManager(new EfColorDal());
			foreach (var color in colorManager.GetAll().Data)
			{
				Console.WriteLine(color.Name);
			}
		}

		private static void CarTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			foreach (var car in carManager.GetAllByBrand(2).Data)
			{
				Console.WriteLine(car.BrandId);
			}
		}
	}
}
