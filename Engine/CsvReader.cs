using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Engine
{
    public class CsvReader
    {
        public List<CsvLine> Read(string filename)
        {
            var result = new List<CsvLine>();

            var reader = new StreamReader(File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            if (!reader.EndOfStream)
            {
                var allLines = File.ReadAllLines(filename);

                var headers = allLines.Take(1).Select(line => line).Single();
                var allContent = allLines.Skip(1).Select(line => new CsvLine(headers, line));

                result.AddRange(allContent);
            }

            return result;
        }
    }
}