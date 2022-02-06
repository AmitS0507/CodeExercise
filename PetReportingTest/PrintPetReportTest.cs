using CodeExcercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PetReportingTest
{
    [TestClass]
    public class PrintPetReportTest
    {
        [TestMethod]
        public void PrintPetReport()
        {
            var pets = new List<IPet>()
            {
                new Dog() { FirstName = "Jim", LastName = "Rogers", NumberOfVisits = 5, JoinedPractice = DateTime.Now},
                new Dog() { FirstName = "Tony", LastName = "Smith", NumberOfVisits = 10, JoinedPractice = new DateTime(1985, 7, 13)},
                new Cat() { FirstName = "Steve", LastName = "Roberts", NumberOfVisits = 20, JoinedPractice = new DateTime(2002, 5, 6), numberOfLives = 9 }
            };
            new PrintPetReport().PrintReport(pets, "PetsReport.csv");
            var outPets = File.ReadAllLines("PetsReport.csv");

            Assert.AreEqual(4, outPets.Count());
        }
    }
}
