using System;
using System.IO;
using System.Diagnostics;

namespace Utilities
{
    public static class ImageViewer
    {
        public static void SelectAndShowImage(string imageUrl)
        {
            // It might be somewhere else - if so go with IE
            const string chromePath = @"C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe";
            var chromeExists = File.Exists(chromePath);
            var iePath = Environment.ExpandEnvironmentVariables(@"%PROGRAMFILES%\Internet Explorer\iexplore.exe");
            var browserPath = chromeExists ? chromePath : iePath;

            ProcessStartInfo info = new ProcessStartInfo(browserPath)
            {
                Arguments = imageUrl,
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Normal,
                Verb = "Open"
            };

            Process.Start(info);
        }
    }
}
