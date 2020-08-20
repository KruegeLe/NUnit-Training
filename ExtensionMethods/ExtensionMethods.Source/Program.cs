using System;


namespace ExtensionMethods.Source 
{
    public class Program
    {
        public string Write(string origin, string formatting)
        {
            return origin.FormatString(formatting);
        }
    }

    public static class Extra
    {
        public static string FormatString(this string s, string formatting)
        {
            return $"{ s } { formatting }";
        }
    } 
}