using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WındowsFormOdeb.ExplorerHelpers
{
    public static class DirectoryScanner
    {
        public static IEnumerable<(string Folder, IEnumerable<string> Classes)>
            Scan(string root)
        {
            foreach (var dir in Directory.GetDirectories(root))
            {
                var classes = Directory.GetFiles(dir, "*.cs")
                   .SelectMany(file =>
                       File.ReadLines(file)
                           .Where(l => l.TrimStart().StartsWith("public class "))
                           .Select(l => l.Split(' ')[2].Split(':')[0]));
                yield return (Path.GetFileName(dir), classes);
            }
        }
    }
}
