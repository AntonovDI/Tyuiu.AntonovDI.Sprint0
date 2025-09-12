using Tyuiu.AntonovDI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AntonovDI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckMessageValid()
        {

            var name = "Даниил";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Привет, Даниил", res);
        }
    }
}
