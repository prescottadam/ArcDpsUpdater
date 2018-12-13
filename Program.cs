using System;
using System.Net;
using NDesk.Options;

namespace ArcDpsUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = "https://www.deltaconnected.com/arcdps/x64/d3d9.dll";
            var defaultTarget = @"C:\Program Files\Guild Wars 2\bin64\d3d9.dll";
            var target = defaultTarget;

            var argParser = new OptionSet()
                .Add("t|target=", delegate (string x) { target = x; })
                .Add("p|path=", delegate (string x) { target = x; });
            argParser.Parse(args);

            if (!target.EndsWith("d3d9.dll", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Target path must be d3d9.dll");
                Console.WriteLine($"Default path: {defaultTarget}");
                return;
            }

            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(source, target);
                }
                Console.WriteLine($"Successfully downloaded to {target}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
