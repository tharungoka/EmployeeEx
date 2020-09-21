using EmployeeEx.Controllers;
using EmployeeEx.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEmployeeEx
{
    [TestClass]
    public class UnitTest1
    {
       // [TestMethod]
        /*public void TestMethod1()
        {
            var controller = new EmployeeController(new EmployeeContext(new DbContextOptions<EmployeeContext>()));
            var request = new Employee
            {
                Id = 100,
                Name = "Tharun Kumar"
            };

            var response = controller.PostEmployee(request);
            Assert.AreEqual(request, response.AsyncState);
        }*/
        [TestMethod]
        public void TestMethod1()
        {
            var controller=new WeatherForecastController(new Logger<WeatherForecastController>(new LoggerFactory()));
            var request = new ForeCastRequest
            {
                 Lattitude=89,
                 Longitude=78
            };
            var response = controller.GetAction(request) as ContentResult;
            Assert.AreEqual(200, response.StatusCode);
        }
    }
}
