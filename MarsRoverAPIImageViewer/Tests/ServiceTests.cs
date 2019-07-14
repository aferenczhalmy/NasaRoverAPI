using System;
using System.IO;
using Xunit;
using NasaAPIService;


namespace Tests
{
    public class ServiceTest1
    {
        private string path = @"..\..\..\..\..\MarsRoverAPIImageViewer\NASAAPIService\dates.txt";
        [Fact]
        public void ReadDataInputFile()
        {
            var dates = DateReader.ReadDates(path);
            Assert.True(dates.Count == 4);
            Assert.True(dates[0] == "02/27/17");
            Assert.True(dates[1] == "June 2, 2018");
            Assert.True(dates[2] == "Jul-13-2016");
            Assert.True(dates[3] == "April 31, 2018");
        }

        [Fact]
        public void TestDateInputs()
        {
            var dates = DateReader.ReadDates(path);

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
            var roverApi = new RoverAPI();
            var imageDate = new FormattedDate("02/27/17");
            var jsonResult = roverApi.GetImagesJson(imageDate);
            var roverImages = NasaRoverImages.FromJson(jsonResult);

            Assert.True(roverImages.Photos.Length > 0);
        }

        [Fact]
        public async void GivenImageListSaveImagesAndVerify()
        {
            var roverApi = new RoverAPI();
            var imageDate = new FormattedDate("02/27/17");
            var imageList = await roverApi.SaveRoverImages(imageDate);

            Assert.True(imageList.Count == 36);
        }

        [Fact]
        public async void DownloadAndShowRandomRoverImageFromSpecifiedDate()
        {
            var roverApi = new RoverAPI();
            var imageDate = new FormattedDate("02/27/17");
            var localFile = ImageViewer.SelectAndShowImage(imageDate);

            Assert.True(File.Exists(localFile));
        }
    }
}
