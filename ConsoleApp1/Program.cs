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
			updatedCar = carManager.Get(5);
			updatedCar.Name = "Jazz";
			carManager.Update(updatedCar);
			CarDtoTest();
		}

		private static void CarAddTest()
		{
			Car newcar = new Car { Name = "Sideswipe", BrandId = 1, ColorId = 2, DailyPrice = 3200, Description = "Sport Car", ModelYear = 2015 };
			CarManager carManager = new CarManager(new EfCarDal());
			carManager.Add(newcar);
			CarDtoTest();
		}

		private static void CarDtoTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			foreach (var car in carManager.GetCarDetail())
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
			foreach (var brand in brandManager.GetAll())
			{
				Console.WriteLine(brand.Name);
			}
		}

		private static void ColorTest()
		{
			ColorManager colorManager = new ColorManager(new EfColorDal());
			foreach (var color in colorManager.GetAll())
			{
				Console.WriteLine(color.Name);
			}
		}

		private static void CarTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			foreach (var car in carManager.GetAllByBrand(2))
			{
				Console.WriteLine(car.BrandId);
			}
		}
	}
}
