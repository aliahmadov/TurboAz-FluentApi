using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TurboAz.DataAccess;
using TurboAz.Domain.Abstractions;
using TurboAz.Domain.Entities;

namespace TurboAz
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IUnitOfWork DB;
        public App()
        {
            DB = new EFUnitOfWork();

            using (var context = new MyContext())
            {
                try
                {
                    context.Database.CreateIfNotExists();
                }
                catch (Exception)
                {

                }
            }

            if (DB.ColorRepository.GetAll().Count == 0)
            {
                var black = new CarColor { ColorName = "Black" };
                var yellow = new CarColor { ColorName = "Yellow" };
                var red = new CarColor { ColorName = "Red" };
                var white = new CarColor { ColorName = "White" };
                var gray = new CarColor { ColorName = "Gray" };
                var blue = new CarColor { ColorName = "Blue" };

                DB.ColorRepository.AddData(black);
                DB.ColorRepository.AddData(yellow);
                DB.ColorRepository.AddData(red);
                DB.ColorRepository.AddData(white);
                DB.ColorRepository.AddData(gray);
                DB.ColorRepository.AddData(blue);
            }


            if (DB.EnergyTypeRepository.GetAll().Count == 0)
            {
                var oil = new EnergyType { TypeName = "Oil" };
                var diesel = new EnergyType { TypeName = "Diesel" };
                var electric = new EnergyType { TypeName = "Electric" };
                var gas = new EnergyType { TypeName = "Gas" };

                DB.EnergyTypeRepository.AddData(oil);
                DB.EnergyTypeRepository.AddData(diesel);
                DB.EnergyTypeRepository.AddData(electric);
                DB.EnergyTypeRepository.AddData(gas);
            }

            if (DB.ManufacturerRepository.GetAll().Count == 0)
            {
                var bentley = new Manufacturer { Name = "Bentley" };
                var bugatti = new Manufacturer { Name = "Bugatti" };
                var tesla = new Manufacturer { Name = "Tesla" };
                var mercedes = new Manufacturer { Name = "Mercedes" };
                var chevrolet = new Manufacturer { Name = "Chevrolet" };
                var toyota = new Manufacturer { Name = "Toyota" };
                var porsche = new Manufacturer { Name = "Porsche" };
                var rangeRover = new Manufacturer { Name = "Range Rover" };
                var jaguar = new Manufacturer { Name = "Jaguar" };
                var ferrari = new Manufacturer { Name = "Ferrari" };
                var jeep = new Manufacturer { Name = "Jeep" };

                DB.ManufacturerRepository.AddData(bentley);
                DB.ManufacturerRepository.AddData(bugatti);
                DB.ManufacturerRepository.AddData(tesla);
                DB.ManufacturerRepository.AddData(mercedes);
                DB.ManufacturerRepository.AddData(chevrolet);
                DB.ManufacturerRepository.AddData(toyota);
                DB.ManufacturerRepository.AddData(porsche);
                DB.ManufacturerRepository.AddData(rangeRover);
                DB.ManufacturerRepository.AddData(jaguar);
                DB.ManufacturerRepository.AddData(ferrari);
                DB.ManufacturerRepository.AddData(jeep);
            }

            if (DB.BanTypeRepository.GetAll().Count == 0)
            {
                var van = new BanType { TypeName = "Van" };
                var sedan = new BanType { TypeName = "Sedan" };
                var jeep = new BanType { TypeName = "Jeep" };
                var truck = new BanType { TypeName = "Truck" };

                DB.BanTypeRepository.AddData(van);
                DB.BanTypeRepository.AddData(sedan);
                DB.BanTypeRepository.AddData(jeep);
                DB.BanTypeRepository.AddData(truck);
            }

            if (DB.CarRepository.GetAll().Count == 0)
            {
                var bentley = new Car
                {
                    ImagePath = "/Images/bentleyBlack.jpg",
                    BanTypeId = 2,
                    ColorId = 1,
                    IsOld = false,
                    Price = 150000,
                    ManufacturerId = 1,
                    ProductionYear = 2015,
                    UsageDistance = 100,
                    EnergyTypeId = 1
                };

                var bugatti = new Car
                {
                    ImagePath = "/Images/bugatti_yellow.jpg",
                    BanTypeId = 2,
                    ColorId = 2,
                    IsOld = true,
                    Price = 500000,
                    ManufacturerId = 2,
                    ProductionYear = 2011,
                    UsageDistance = 2500,
                    EnergyTypeId = 1
                };

                var camaro = new Car
                {
                    ImagePath = "/Images/camaroWhite.jpg",
                    BanTypeId = 2,
                    ColorId = 4,
                    IsOld = true,
                    Price = 500000,
                    ManufacturerId = 5,
                    ProductionYear = 2013,
                    UsageDistance = 3500,
                    EnergyTypeId = 1,

                };

                var ferrariRed = new Car
                {
                    ImagePath = "/Images/ferrariRed.jpg",
                    BanTypeId = 2,
                    ColorId = 3,
                    IsOld = false,
                    Price = 1200000,
                    ManufacturerId = 10,
                    ProductionYear = 2018,
                    UsageDistance = 6500,
                    EnergyTypeId = 1,

                };

                var ferrariWhite = new Car
                {
                    ImagePath = "/Images/ferrariWhite.jpg",
                    BanTypeId = 2,
                    ColorId = 4,
                    IsOld = false,
                    Price = 1375000,
                    ManufacturerId = 10,
                    ProductionYear = 2018,
                    UsageDistance = 6500,
                    EnergyTypeId = 1,

                };

                var jaguarRed = new Car
                {
                    ImagePath = "/Images/jaguarRed.jpg",
                    BanTypeId = 2,
                    ColorId = 3,
                    IsOld = false,
                    Price = 350000,
                    ManufacturerId = 9,
                    ProductionYear = 2019,
                    UsageDistance = 2100,
                    EnergyTypeId = 1,

                };

                var jeep = new Car
                {
                    ImagePath = "/Images/jeep.jpg",
                    BanTypeId = 3,
                    ColorId = 4,
                    IsOld = true,
                    Price = 350000,
                    ManufacturerId = 11,
                    ProductionYear = 2014,
                    UsageDistance = 9000,
                    EnergyTypeId = 1,
                     
                };

                var landCruiser = new Car
                {
                    ImagePath = "/Images/landCruiserWhite.jpg",
                    BanTypeId = 3,
                    ColorId = 4,
                    IsOld = false,
                    Price = 247000,
                    ManufacturerId = 6,
                    ProductionYear = 2020,
                    UsageDistance = 1025,
                    EnergyTypeId = 1,
               
                };


                var lexus = new Car
                {
                    ImagePath = "/Images/lexus_gray.jpg",
                    BanTypeId = 3,
                    ColorId = 5,
                    IsOld = false,
                    Price = 155000,
                    ManufacturerId = 6,
                    ProductionYear = 2021,
                    UsageDistance = 232,
                    EnergyTypeId = 1,
                  
                };


                var malibu = new Car
                {
                    ImagePath = "/Images/malibuRed.jpg",
                    BanTypeId = 2,
                    ColorId = 3,
                    IsOld = true,
                    Price = 50000,
                    ManufacturerId = 5,
                    ProductionYear = 2014,
                    UsageDistance = 3596,
                    EnergyTypeId = 1,
                 
                };

                var mercedes = new Car
                {
                    ImagePath = "/Images/mercedes.jpg",
                    BanTypeId = 2,
                    ColorId = 1,
                    IsOld = false,
                    Price = 75000,
                    ManufacturerId = 4,
                    ProductionYear = 2018,
                    UsageDistance = 1245,
                    EnergyTypeId = 1,
                   
                };

                var maybach = new Car
                {
                    ImagePath = "/Images/mercedesMaybach.jpg",
                    BanTypeId = 2,
                    ColorId = 5,
                    IsOld = false,
                    Price = 450000,
                    ManufacturerId = 4,
                    ProductionYear = 2020,
                    UsageDistance = 100,
                    EnergyTypeId = 1,
                
                };

                var Ml = new Car
                {
                    ImagePath = "/Images/mercedesMl.jpg",
                    BanTypeId = 3,
                    ColorId = 3,
                    IsOld = true,
                    Price = 45000,
                    ManufacturerId = 4,
                    ProductionYear = 2012,
                    UsageDistance = 3241,
                    EnergyTypeId = 1,
                   
                };

                var suv = new Car
                {
                    ImagePath = "/Images/mercedesSuvBlue.jpg",
                    BanTypeId = 3,
                    ColorId = 6,
                    IsOld = true,
                    Price = 35000,
                    ManufacturerId = 4,
                    ProductionYear = 2015,
                    UsageDistance = 2547,
                    EnergyTypeId = 1,
                  
                };

                var van = new Car
                {
                    ImagePath = "/Images/mercedesVan.jpg",
                    BanTypeId = 1,
                    ColorId = 4,
                    IsOld = false,
                    Price = 120000,
                    ManufacturerId = 4,
                    ProductionYear = 2017,
                    UsageDistance = 1254,
                    EnergyTypeId = 2,
               
                };

                var porsche = new Car
                {
                    ImagePath = "/Images/porscheRed.jpg",
                    BanTypeId = 2,
                    ColorId = 3,
                    IsOld = true,
                    Price = 85000,
                    ManufacturerId = 7,
                    ProductionYear = 2015,
                    UsageDistance = 3524,
                    EnergyTypeId = 1,
                  
                };

                var rover = new Car
                {
                    ImagePath = "/Images/rangeRover.jpg",
                    BanTypeId = 3,
                    ColorId = 2,
                    IsOld = false,
                    Price = 265800,
                    ManufacturerId = 8,
                    ProductionYear = 2020,
                    UsageDistance = 3524,
                    EnergyTypeId = 1,
               
                };

                var rover_black = new Car
                {
                    ImagePath = "/Images/Rover_black.jpg",
                    BanTypeId = 3,
                    ColorId = 1,
                    IsOld = true,
                    Price = 165745,
                    ManufacturerId = 8,
                    ProductionYear = 2015,
                    UsageDistance = 4520,
                    EnergyTypeId = 1,
      
                };

                var truck = new Car
                {
                    ImagePath = "/Images/teslaTruck.jpg",
                    BanTypeId = 4,
                    ColorId = 5,
                    IsOld = false,
                    Price = 750000,
                    ManufacturerId = 3,
                    ProductionYear = 2021,
                    UsageDistance = 4520,
                    EnergyTypeId = 3,
            
                };

                var tesla = new Car
                {
                    ImagePath = "/Images/teslaYellow.jpg",
                    BanTypeId = 2,
                    ColorId = 2,
                    IsOld = false,
                    Price = 450000,
                    ManufacturerId = 3,
                    ProductionYear = 2020,
                    UsageDistance = 1200,
                    EnergyTypeId = 3,
            
                };

                DB.CarRepository.AddData(bentley);
                DB.CarRepository.AddData(bugatti);
                DB.CarRepository.AddData(camaro);
                DB.CarRepository.AddData(ferrariRed);
                DB.CarRepository.AddData(ferrariWhite);
                DB.CarRepository.AddData(jaguarRed);
                DB.CarRepository.AddData(jeep);
                DB.CarRepository.AddData(landCruiser);
                DB.CarRepository.AddData(lexus);
                DB.CarRepository.AddData(malibu);
                DB.CarRepository.AddData(mercedes);
                DB.CarRepository.AddData(maybach);
                DB.CarRepository.AddData(Ml);
                DB.CarRepository.AddData(suv);
                DB.CarRepository.AddData(van);
                DB.CarRepository.AddData(porsche);
                DB.CarRepository.AddData(rover);
                DB.CarRepository.AddData(rover_black);
                DB.CarRepository.AddData(tesla);
                DB.CarRepository.AddData(truck);
               // DB.CarRepository.AddData(bentley);


            }



        }
    }
}
