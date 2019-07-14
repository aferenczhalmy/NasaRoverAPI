using System;
using System.IO;
using Xunit;
using NasaAPIService;
using Microsoft.Extensions.Configuration;

namespace Tests
{
    public class ServiceTest1
    {
        readonly string _path = @"..\..\..\..\..\MarsRoverAPIImageViewer\NASAAPIService\dates.txt";
        readonly FormattedDate _imageDate = new FormattedDate("02/27/17");

        private string GetEndPoint()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();
            return configuration.GetSection("EndPoint").Value;
        }

        public IRoverApi GetRoverApi()
        {
            var isTest = true;
            return isTest ? new RoverTestApi(GetEndPoint()) : new RoverApi(GetEndPoint());
        }

        [Fact]
        public void ReadDataInputFile()
        {
            var dates = DateReader.ReadDates(_path);
            Assert.True(dates.Count == 4);
            Assert.True(dates[0] == "02/27/17");
            Assert.True(dates[1] == "June 2, 2018");
            Assert.True(dates[2] == "Jul-13-2016");
            Assert.True(dates[3] == "April 31, 2018");
        }

        [Fact]
        public void TestDateInputs()
        {
            var dates = DateReader.ReadDates(_path);

            var date1 = new FormattedDate(dates[0]);
            Assert.True(date1.FormattedDateString == "2017-02-27");
            var date2 = new FormattedDate(dates[1]);
            Assert.True(date2.FormattedDateString == "2018-06-02");
            var date3 = new FormattedDate(dates[2]);
            Assert.True(date3.FormattedDateString == "2016-07-13");
            Func<FormattedDate> date4 = () => new FormattedDate(dates[3]);
            Assert.Throws<System.FormatException>(date4);
        }

        [Fact]
        public void VerifyServiceEndPoint()
        {
            var jsonResult = GetRoverApi().GetImagesJson(_imageDate);
            var roverImages = NasaRoverImages.FromJson(jsonResult);

            Assert.True(roverImages.Photos.Length > 0);
        }

        [Fact]
        public async void GivenImageListSaveImagesAndVerify()
        {
            var imageList = await GetRoverApi().SaveRoverImages(_imageDate);

            Assert.True(imageList.Count == 36);
        }

        [Fact]
        public async void DownloadAndShowRandomRoverImageFromSpecifiedDate()
        {
            var roverAPI = GetRoverApi();
            var roverImages = roverAPI.GetImages(_imageDate);
            var randomImageIndex = new Random().Next(0, roverImages.Photos.Length - 1);
            var localFilePathAndName = roverAPI.SaveRoverImage(_imageDate, roverImages.Photos[randomImageIndex]);
            var randomImage = roverImages.Photos[randomImageIndex].ImgSrc.ToString();

            ImageViewer.SelectAndShowImage(randomImage);

            Assert.True(File.Exists(localFilePathAndName));
        }
    }
}
