using System;
using System.Text;

namespace WorkingWithStrings
{
    public static class SplittingStrings
    {
        /// <summary>
        /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitCommaSeparatedString(string str)
        {
            return str.Split(',');
        }

        /// <summary>
        /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonSeparatedString(string str)
        {
            return str.Split(':');
        }

        /// <summary>
        /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitCommaSeparatedStringMaxTwoElements(string str)
        {
            return str.Split(',', 2);
        }

        /// <summary>
        /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonSeparatedStringMaxThreeElements(string str)
        {
            return str.Split(':', 3);
    
        }

        /// <summary>
        /// Splits a hyphen-separated string into substrings that are based on the hyphen character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings(string str)
        {
            return str.Split('-', 3, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Splits a separated string that is separated with colon and comma characters into substrings, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings(string str)
        {

            char[] seps = new char[] { ':', ',' };
            string[] MyWords = str.Split(seps, 4, StringSplitOptions.RemoveEmptyEntries);   
            return MyWords;
        }

        /// <summary>
        /// Splits a sentence into substrings, and return an array whose elements contain only words.
        /// </summary>
        public static string[] GetOnlyWords(string str)
        {
            char[] seps = new char[] { '.', ',', ':', '\t', '-', '!', ' ' };
            string[] MyWords = str.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            return MyWords;
        }

        /// <summary>
        /// Splits a CSV (comma-separated values) string into substrings that are based on the comma character, and return an array of the CSV line elements.
        /// </summary>
        public static string[] GetDataFromCsvLine(string str)
        {
            char[] seps = new char[] { ' ', ',' };
            return str.Split(seps, StringSplitOptions.RemoveEmptyEntries);
           
        }
    }
}
