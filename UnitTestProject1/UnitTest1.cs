using EmployeeEx.Controllers;
using EmployeeEx.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xunit.Sdk;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new WeatherForecastController(new Logger<WeatherForecastController>(new LoggerFactory()));
            var request = new ForeCastRequest
            {
                Longitude = 89,
                Lattitude = 78
            };
            var response = controller.GetAction(request) as ContentResult;
            Assert.AreEqual(200, response.StatusCode);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var controller = new EmployeeController(new EmployeeContext(new DbContextOptions<EmployeeContext>()));
            var request = new Employee
            {
                Id = 100,
                Name = "Tharun Kumar"
            };
            var response = controller.GetEmployees() as Task<ActionResult<IEnumerable<Employee>>>;
            Assert.AreEqual(true, response.IsCompleted);   
        }

    }
}
