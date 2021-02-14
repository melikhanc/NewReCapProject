using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarTest();

            RentalDetailTest();


           
        }

        private static void RentalDetailTest()
        {
            RentalDetailsManager rentalDetailsManager = new RentalDetailsManager(new EfRentalDetailsDal());

            var result = rentalDetailsManager.GetAll();
            if (result.Success)
            {
                foreach (var rentalDetails in result.Data)
                {
                    Console.WriteLine(rentalDetails.Id+ " / " +rentalDetails.RentalCustomerId + "/" + rentalDetails.CarId ) ;

                }
            }

            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {

                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.ModelYear + " / " + car.Description);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

    }
}



