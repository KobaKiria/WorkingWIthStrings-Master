using System;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
// ReSharper disable IdentifierTypo
namespace WorkingWithStrings
{
    public static class StringLiterals
    {
        /// <summary>
        /// Returns a "abc" string.
        /// </summary>
        public static string ReturnAbcStringLiteral()
        {
            return "abc";
        }

        /// <summary>
        /// Returns a "ABCDEF" string.
        /// </summary>
        public static string ReturnAbcdefStringLiteral()
        {
            return "ABCDEF"; 
        }

        /// <summary>
        /// Returns an empty string.
        /// </summary>
        public static string ReturnEmptyString()
        {

            return String.Empty; 
        
        }

        /// <summary>
        /// Returns a file path.
        /// </summary>
        public static string ReturnFilePathStringLiteral()
        {
            return "c:\\documents\\files\\myfile0234.txt"; 
        }

        /// <summary>
        /// Returns a file path.
        /// </summary>
        public static string ReturnFilePathVerbatimStringLiteral()
        {
            return @"c:\documents\files\myfile0234.txt";

        }
    }
}
