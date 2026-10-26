using Tyuiu.KhomutovaLE.Sprint4.Task1.V10.Lib;

namespace Tyuiu.KhomutovaLE.Sprint4.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5 };
            int res = ds.Calculate(array);
            int wait = 1125;
            Assert.AreEqual(wait, res);
        }
    }
}
