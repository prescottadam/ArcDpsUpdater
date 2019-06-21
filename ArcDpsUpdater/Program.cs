using System;
using System.IO;
using System.Net;
using NDesk.Options;

namespace ArcDpsUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            var arcDpsDll = "d3d9.dll";
            var arcDpsSource = $"https://www.deltaconnected.com/arcdps/x64/{arcDpsDll}";

            var buildTemplatesDll = "d3d9_arcdps_buildtemplates.dll";
            var buildTemplatesSource = $"https://www.deltaconnected.com/arcdps/x64/buildtemplates/{buildTemplatesDll}";

            var defaultTargetDir = @"C:\Program Files\Guild Wars 2\bin64";
            var targetDir = defaultTargetDir;

            var argParser = new OptionSet()
                .Add("t|target=", delegate (string x) { targetDir = x; })
                .Add("p|path=", delegate (string x) { targetDir = x; });
            argParser.Parse(args);

            if (!Directory.Exists(targetDir))
            {
                Console.WriteLine("Target path a valid folder");
                Console.WriteLine($"Default path: {defaultTargetDir}");
                return;
            }

            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(arcDpsSource, Path.Combine(targetDir, arcDpsDll));
                    client.DownloadFile(buildTemplatesSource, Path.Combine(targetDir, buildTemplatesDll));
                }
                Console.WriteLine($"Successfully downloaded to {targetDir}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
