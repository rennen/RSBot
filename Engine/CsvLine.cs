using System.Collections.Generic;

namespace Engine
{
    public class CsvLine
    {
        private readonly List<string> headers;
        private readonly string[] lineParts;

        public CsvLine(string headers, string content)
        {
            this.headers = new List<string>(headers.Split(','));
            lineParts = content.Split(',');
        }

        public string this[string index] => lineParts[headers.IndexOf(index)];
    }
}