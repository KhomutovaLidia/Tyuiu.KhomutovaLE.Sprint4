using Tyuiu.KhomutovaLE.Sprint4.Task6.V12.Lib;

namespace Tyuiu.KhomutovaLE.Sprint4.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };
            string[] res = ds.Calculate(array);
            string[] wait = {"Украина", "Молдова", "Эстония" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
