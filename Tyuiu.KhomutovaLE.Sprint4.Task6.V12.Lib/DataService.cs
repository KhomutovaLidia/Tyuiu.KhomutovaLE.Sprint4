using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhomutovaLE.Sprint4.Task6.V12.Lib
{
    public class DataService : ISprint4Task6V12
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, x => x.Length == 7);
            return res;
        }
    }
}
