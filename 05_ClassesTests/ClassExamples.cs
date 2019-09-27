using System;
using _05_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ClassesTests
{
    [TestClass]
    public class ClassExamples
    {
        [TestMethod]
        public void CookieClassInstantiation()
        {
            Cookie cookie = new Cookie();

            cookie.Name = "SnickerDoodle";
            cookie.Ingredient = "Chocolate";
            cookie.Shape = "Circle";
            cookie.Size = "Big";
            cookie.BatchSize = 12;
            cookie.Direction = "left";

            Cookie cookieTwo = new Cookie();

            cookieTwo.Name = "Chocolate Chip";
            cookieTwo.Ingredient = "Chocolate";
            cookieTwo.Shape = "Circle";
            cookieTwo.Size = "Bigger";
            cookieTwo.BatchSize = 12;
            cookieTwo.Direction = "right";

            Cookie cookieThree = new Cookie("Oreo", "Chocolate", "Small", "Up", "Circle", 24);

            cookie.SetSize();

        }

        [TestMethod]
        public void VehicleClassInstantiation()
        {
            Vehicle vehicleOne = new Vehicle("Ford", "Focus", 123.04d, "Red", "1234", 2002, 6, "Hatchback");

            Vehicle vehicleTwo = new Vehicle();

            vehicleTwo.Make = "Honda";
            vehicleTwo.Model = "CRV";
            vehicleTwo.Mileage = 280000d;
            vehicleTwo.Color = "Gray";
            vehicleTwo.VIN = "4321";
            vehicleTwo.Year = 2006;
            vehicleTwo.CoolnessFactor = 11;
            vehicleTwo.TypeOfVehicle = "SUV";
            vehicleTwo.IsRunning = true;

            Vehicle vehicleThree = new Vehicle();

            vehicleOne.StartVehicle();
            //vehicleOne.StopVehicle();     

            Assert.IsTrue(vehicleOne.IsRunning);
            //Assert.IsFalse(vehicleOne.IsRunning);

            vehicleTwo.CoolFactorBump();

            Assert.IsTrue(vehicleTwo.CoolnessFactor == 12);
        }
    }
}
