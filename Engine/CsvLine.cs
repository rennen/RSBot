using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace Engine
{
    public class CsvLine
    {
        private readonly List<string> headers;
        private readonly string[] lineParts;

        public CsvLine(string headers, string content)
        {
            var headersParser = new TextFieldParser(new StringReader(headers));
            headersParser.HasFieldsEnclosedInQuotes = true;
            headersParser.SetDelimiters(",");            
            this.headers = new List<string>(headersParser.ReadFields());

            var lineParser = new TextFieldParser(new StringReader(content));
            lineParser.HasFieldsEnclosedInQuotes = true;
            lineParser.SetDelimiters(",");

            lineParts = lineParser.ReadFields();
        }

        public string this[string index] => lineParts[headers.IndexOf(index)];
    }
}