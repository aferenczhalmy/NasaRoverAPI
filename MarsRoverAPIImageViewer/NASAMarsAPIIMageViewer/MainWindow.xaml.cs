using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.Configuration;
using Microsoft.SqlServer.Server;
using NasaAPIService;
using Utilities;


namespace NASAMarsAPIIMageViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FormattedDate FormattedDate { get; set; }
        public string EndPoint { get; set; }
        public bool IsTest { get; set; }
        public string DateFile { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            SetupConfiguration();

            var items = new ObservableCollection<string>();
            var dates = DateReader.ReadDates(DateFile).ToList();
            dates.ForEach(d => items.Add(d));
            DatesCmb.ItemsSource = items;

        }

        private void SetupConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();
            IsTest = Boolean.Parse(configuration.GetSection("IsTest").Value);
            EndPoint = configuration.GetSection("EndPoint").Value;
            DateFile = configuration.GetSection("DateFile").Value;
        }

        public IRoverApi GetRoverApi()
        {
            return IsTest ? new RoverTestApi(EndPoint) : new RoverApi(EndPoint);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var roverAPI = GetRoverApi();
            var roverImages = roverAPI.GetImages(FormattedDate);
            var randomImageIndex = new Random().Next(0, roverImages.Photos.Length - 1);
            var localFilePathAndName = roverAPI.SaveRoverImage(FormattedDate, roverImages.Photos[randomImageIndex]);
            var randomImage = roverImages.Photos[randomImageIndex].ImgSrc.ToString();

            ImageViewer.SelectAndShowImage(randomImage);
        }

        private void DatesCmb_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                FormattedDate = new FormattedDate((string) DatesCmb.SelectedItem);
                GetImageBtn.IsEnabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"The date {DatesCmb.SelectedItem} is invalid, please choose a valid date");
                GetImageBtn.IsEnabled = false;
            }
        }
    }
}
