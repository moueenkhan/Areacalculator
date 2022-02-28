using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea;

namespace Tests
{
    [TestClass]
    public class CalculateAreaTests
    {
        [TestMethod]
        public void square_area_should_be_25_with_side_5()
        {
           var square = new Square(5.0f);
           var result = square.GetArea();
           Assert.IsTrue(result == 25.0f);
        }
    }
}
