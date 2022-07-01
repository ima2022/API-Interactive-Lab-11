using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;
using API_Interactive_Lab_1.Models;
using API_Interactive_Lab_1;
namespace API_Interactive_Lab_1.Tests
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetHome()
        {

            string expectedContent = "I Like Coffee!";

            var controller = new CoffeeController();
            var result = controller.GetCoffeeLover();
            Assert.AreEqual(expectedContent, result);
        }
    }
}