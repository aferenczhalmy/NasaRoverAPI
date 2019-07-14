using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NasaAPIService
{
    public static class DateReader
    {
        public static List<string> ReadDates(string path)
        {
            var lines = System.IO.File.ReadAllLines(path);
            return lines.ToList();
        }
    }
}
