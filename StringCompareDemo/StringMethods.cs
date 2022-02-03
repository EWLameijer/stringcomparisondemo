using System;

namespace StringCompareDemo
{
    public class StringMethods
    {
        public static bool ContainsCaseInsensitive(string sought, string toSearch)
        {
            return toSearch.Contains(sought, StringComparison.OrdinalIgnoreCase);
        }
    }
}
