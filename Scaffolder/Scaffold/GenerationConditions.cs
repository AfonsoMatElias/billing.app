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
                Logger.Log("");
                Logger.Warn($"Do you want to remake '{name}{tail}.cs' ?");
                Logger.Log("[{y|Yellow} - (yes), {n|Yellow} - (no), {ya|Yellow} - (yes for all), {na|Yellow} - (no for all)]: ");
                var op = Console.ReadLine();
                Logger.Log("");

                switch (op)
                {
                    case "y": return true;
                    case "ya":
                        YesForAll = true;
                        return true;
                    case "n":
                        Logger.Warn($"WARMING: File '{name}{tail}.cs' was not created!\n");
                        return false;
                    case "na":
                        NoForAll = true;
                        return false;
                    default:
                        Logger.Warn($"WARMING: File '{name}{tail}.cs' was not created!\n");
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
