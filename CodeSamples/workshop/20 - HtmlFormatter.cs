using System;

namespace UnitTestsFortTesters
{
    public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            return $"<strong>{content}</strong>";
        }

        /// <summary>
        /// refactored FormatAsBold() method for BONUS EXERCISE
        /// </summary>
        /// <returns></returns>
        //public string FormatAsBold(string content) //other possible implementation
        //{
        //    return String.Format("<strong>{0}</strong>", content);
        //}

    }
}



