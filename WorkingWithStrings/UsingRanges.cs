using System;

namespace WorkingWithStrings
{
    public static class UsingRanges
    {
        /// <summary>
        /// Gets a string with all characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithAllChars(string str)
        {
            return str[..];
        }

        /// <summary>
        /// Gets a string without first character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutFirstChar(string str)
        {
            return str.Substring(1);

        }

        /// <summary>
        /// Gets a string without two first character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutTwoFirstChars(string str)
        {
            return str.Substring(2);
        }

        /// <summary>
        /// Gets a string without three first character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutThreeFirstChars(string str)
        {
            return str.Substring(3);
        }

        /// <summary>
        /// Gets a string without a last character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutLastChar(string str)
        {
            return str.Substring(0, str.Length-1);
        }

        /// <summary>
        /// Gets a string without a two last characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutTwoLastChars(string str)
        {
            return str.Substring(0, str.Length - 2);
        }

        /// <summary>
        /// Gets a string without a three last characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutThreeLastChars(string str)
        {
            return str.Substring(0, str.Length - 3);
        }

        /// <summary>
        /// Gets a string without the first and the last characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutFirstAndLastChars(string str)
        {
            return str.Substring(1, str.Length - 2);
        }

        /// <summary>
        /// Gets a string without the first two and the last two characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutTwoFirstAndTwoLastChars(string str)
        {
            return str.Substring (2, str.Length - 4);
        }

        /// <summary>
        /// Gets a string without the first three and the last three characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutThreeFirstAndThreeLastChars(string str)
        {
            return str.Substring(3, str.Length - 6);
        }

        /// <summary>
        /// Gets details of the production code.
        /// </summary>
        public static void GetProductionCodeDetails(string productionCode, out string regionCode, out string locationCode, out string dateCode, out string factoryCode)
        {
            regionCode = productionCode.Substring(0, productionCode.Length - 15);
            locationCode = productionCode.Substring(3, productionCode.Length - 14);
            dateCode = productionCode.Substring(7, productionCode.Length - 13);
            factoryCode = productionCode.Substring(12);



        }

        /// <summary>
        /// Gets details of the production code.
        /// </summary>
        public static void GetSerialNumberDetails(string serialNumber, out string countryCode, out string manufacturerCode, out string factoryCode, out string stationCode)
        {
           
            countryCode = serialNumber.Substring(serialNumber.Length - 9, 1);
            manufacturerCode = serialNumber.Substring(serialNumber.Length - 8, 2);
            factoryCode = serialNumber.Substring(serialNumber.Length - 5, 4);
            stationCode  = serialNumber.Substring(serialNumber.Length - 1);
            
 
            

        }
    }
}
