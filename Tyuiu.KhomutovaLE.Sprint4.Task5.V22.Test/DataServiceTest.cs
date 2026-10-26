using Tyuiu.KhomutovaLE.Sprint4.Task5.V22.Lib;

namespace Tyuiu.KhomutovaLE.Sprint4.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { {2, -5, -1, 7, 5 },
                        {4, 4, 7, -4, -4 },
                        {7, -1, 6, 8, 8 },
                        {8, 1, -5, -8, 4 },
                        {8, 9, -1, -7, -3 } };
            int res = ds.Calculate(array);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}
