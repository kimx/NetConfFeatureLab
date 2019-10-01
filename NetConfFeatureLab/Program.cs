using System;
using System.Collections.Generic;

namespace NetConfFeatureLab
{
    /// <summary>
    /// Try.Net 線上文件測試
    /// </summary>
    class Program
    {

        static void Main(string region = null,
        string[] args = null)
        {
            switch (region)
            {
                case "intro":
                    Intro();
                    break;
                case "collections":
                    Collections();
                    break;
            }
        }
        public static void Intro()
        {
            #region intro
            Console.WriteLine("Hello World!");
            #endregion
        }

        public static void Collections()
        {
            #region collections
            var names = new List<string> { "Rain", "Sage", "Lee" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            #endregion
        }
    }
}
