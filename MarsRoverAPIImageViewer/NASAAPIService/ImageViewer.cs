using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace NasaAPIService
{
    public static class ImageViewer
    {
        public static string SelectAndShowImage(FormattedDate formattedDate)
        {
            var roverAPI = new RoverAPI();
            var roverImages = roverAPI.GetImages(formattedDate);
            var randomImageIndex = new Random().Next(0, roverImages.Photos.Length - 1);

            const string chromePath = @"C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe";
            var chromeExists = File.Exists(chromePath);
            var iePath = Environment.ExpandEnvironmentVariables(@"%PROGRAMFILES%\Internet Explorer\iexplore.exe");
            var browserPath = chromeExists ? chromePath : iePath;

            ProcessStartInfo info = new ProcessStartInfo(browserPath);
            var localFilePathAndName = roverAPI.SaveRoverImage(formattedDate, roverImages.Photos[randomImageIndex]);
            var randomImage = roverImages.Photos[randomImageIndex].ImgSrc.ToString();

            info.Arguments = randomImage;
            info.UseShellExecute = true;
            info.WindowStyle = ProcessWindowStyle.Normal;
            info.Verb = "OPEN";

            Process.Start(info);
            return localFilePathAndName;
        }
    }
}
