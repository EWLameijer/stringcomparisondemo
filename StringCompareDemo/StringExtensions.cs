using System;
using System.Linq;

namespace StringCompareDemo
{
    static public class StringExtensions
    {
        // see also discussion at https://stackoverflow.com/questions/444798/case-insensitive-containsstring
        /// <summary>
        /// Finds a string (case insensitive) in a list of other strings.
        /// Usage: soughtString.InAnyIgnoringCase(firstStringToSearch, secondStringToSearch..., lastStringToSearch)
        /// </summary>
        /// <param name="stringToFind"></param>
        /// <param name="stringsToSearch"></param>
        /// <returns>whether the sought string is in any target string</returns> 

        // Notes: 'tricks' used here
        // 1. extension method: static method in static class, first argument 'this TYPE IDENTIFIER'
        //    Why? can now do sought.InAnyIgnoringCase(stringToSearch), making clear which string is looked for, and 
        //         which strings are looked IN.
        // 2. expression bodied method (=>)
        //    Why? If a method is short, using => EXPRESSION; instead of { return EXPRESSION; } saves two rather
        //         useless lines. Of course, it looks ugly, especially if you aren't used to it.
        // 3. params (varargs in some other languages)
        //    Why? We needed to search in more than one string. Why not be flexible, instead of if (a.IsInIgnoringCase(b)
        //         || a.IsInIgnoringCase(c) || a.IsInIgnoringCase(d) .. a.InAnyIgnoringCase(b,c,d) is shorter and simpler
        //         and avoids useless repetition of the method call.
        // 4. If you can think of something even nicer, let me know!
        static public bool InAnyIgnoringCase(this string stringToFind, params string[] stringsToSearch) =>
             stringsToSearch.Any(s => s.Contains(stringToFind, StringComparison.OrdinalIgnoreCase));
    }
}
