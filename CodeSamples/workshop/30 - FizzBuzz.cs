namespace UnitTestsFortTesters
{
    public class FizzBuzz
    {
        public static string GetOutput(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }

        /// <summary>
        /// refactored GetOutput() method for BONUS EXERCISE
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        //public static string GetOutput(int number) //refactored ccode
        //{
        //    string str = "";
        //    if (number % 3 == 0)
        //    {
        //        str += "Fizz";
        //    }
        //    if (number % 5 == 0)
        //    {
        //        str += "Buzz";
        //    }
        //    if (str.Length == 0)
        //    {
        //        str = number.ToString();
        //    }
        //    return str;
        //}
    }
}