using System;

namespace StringCompareDemo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\nWith an regular method:");
            TestPresenceNormalMethod("bath", "in");
            TestPresenceNormalMethod("Bath", "bathtub");
            TestPresenceNormalMethod("bath", "inbAtha");

            Console.WriteLine("\nWith an extension method:");
            TestPresenceExtensionMethod("Bath", "in", "mybat", "htub");
            TestPresenceExtensionMethod("Bath", "in", "mybat", "bathtub");
            TestPresenceExtensionMethod("bath", "inbATh", "mybat", "xathtub");
        }

        private static void TestPresenceNormalMethod(string v1, string v2)
        {
            Console.WriteLine($"Is {v1} in {v2}? {StringMethods.ContainsCaseInsensitive(v1, v2)}");
        }

        private static void TestPresenceExtensionMethod(string v1, string v2, string v3, string v4)
        {
            Console.WriteLine($"Is {v1} in {v2}/{v3}/{v4}? {v1.InAnyIgnoringCase(v2, v3, v4)}"); ;
        }
    }
}
