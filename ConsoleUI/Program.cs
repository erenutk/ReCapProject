using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car() { Id = 8, BrandId = 13, ColorId = 53, DailyPrice = 400, Description = "Honda Civic", ModelYear = 1988 };
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(car1);            
            carManager.Update(8);
            //carManager.Delete(car1);
            Console.WriteLine(carManager.GetById(5));

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
