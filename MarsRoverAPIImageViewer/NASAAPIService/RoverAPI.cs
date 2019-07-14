using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace NasaAPIService
{
    public class RoverAPI
    {
        public string GetImagesJson(FormattedDate formattedDate)
        {
            var endPoint = $"https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date={formattedDate.FormattedDateString}&api_key=DEMO_KEY";
            var result = "";

            var request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = "GET";

            using (var response = (HttpWebResponse) request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("Error Calling Nasa Rover API Rest Service " + response.StatusCode.ToString());
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            result = reader.ReadToEnd();
                        }
                    }
                }
            }

            return result;
        }

        public NasaRoverImages GetImages(FormattedDate formattedDate)
        {
            var jsonResult = GetImagesJson(formattedDate);
            return NasaRoverImages.FromJson(jsonResult);
        }

        public string SaveRoverImage(FormattedDate formattedDate, Photo roverImage)
        {
            var saveLocation = $@".\images\{formattedDate.FormattedDateString}";
            var dirLocation = Directory.CreateDirectory(saveLocation);
            var fileName = Path.GetFileName(roverImage.ImgSrc.LocalPath);
            using (var webClient = new WebClient())
            {
                webClient.DownloadFileAsync(roverImage.ImgSrc, saveLocation + $@"\{fileName}");
            }

            return dirLocation.FullName + $@"\{fileName}";
        }

        public async Task<List<string>> SaveRoverImages(FormattedDate formattedDate)
        {
            var imageList = new List<string>();

            var roverImages = GetImages(formattedDate);

            foreach (var roverImage in roverImages.Photos)
            {
                var fullPathAndFileName = SaveRoverImage(formattedDate, roverImage);
                imageList.Add(fullPathAndFileName);
            }

            return imageList;
        }
    }
}
