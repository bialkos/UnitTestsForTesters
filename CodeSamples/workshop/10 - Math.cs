using System.Collections.Generic;
using System.Linq;

namespace UnitTestsFortTesters
{
    public class Math
    {
        public int Add(int a, int b)
        { 
            return a + b;
        }
        
        public int GetGreaterNumber(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i;
        }

        /// <summary>
        /// refactored GetOddNumbers() method for BONUS EXERCISE
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        //public IEnumerable<int> GetOddNumbers(int limit)
        //{
        //    List<int> temp = new List<int>();
        //    for (var i = 0; i <= limit; i++)
        //        if (i % 2 != 0)
        //        {
        //            temp.Add(i);
        //        }
        //    return temp.AsEnumerable();
        //}
    }
}