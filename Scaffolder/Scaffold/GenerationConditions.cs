using System;

namespace Scaffolder.Scaffold
{
    public class GenerationConditions
    {
        protected bool? YesForAll;
        protected bool? NoForAll;

        public bool Ask(string name, string tail)
        {
            if (YesForAll == null && NoForAll == null)
            {
                Console.WriteLine("");
                SharedMethods.ChangeColor(ConsoleColor.Yellow, () =>
                    Console.WriteLine($"Do you want to remake '{name}{tail}.cs' ?"));
                Console.Write("[y - (yes), n - (no), ya - (yes for all), na - (no for all)]: ");
                var op = Console.ReadLine();
                Console.WriteLine("");

                switch (op)
                {
                    case "y": return true;
                    case "ya":
                        YesForAll = true;
                        return true;
                    case "n":
                        SharedMethods.ChangeColor(ConsoleColor.Yellow, () =>
                            Console.WriteLine($"WARMING: File '{name}{tail}.cs' was not created!\n"));
                        return false;
                    case "na":
                        NoForAll = true;
                        return false;
                    default:
                        SharedMethods.ChangeColor(ConsoleColor.Yellow, () =>
                            Console.WriteLine($"WARMING: File '{name}{tail}.cs' was not created!\n"));
                        return false;
                }
            }
            else
            {
                if (NoForAll == true)
                    return false;

                return true;
            }

        }
    }

}
