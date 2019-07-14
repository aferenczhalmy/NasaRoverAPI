using System;
using System.Collections.Generic;
using System.Text;

namespace NasaAPIService
{
    public class FormattedDate
    {
        public string FormattedDateString { get; private set; }
        public FormattedDate(string date)
        {
            var dateTime = DateTime.Parse(date);
            FormattedDateString = dateTime.ToString("yyyy-MM-dd");
        }
    }
}
