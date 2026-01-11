using Queens_Gallery.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Queens_Gallery.Pages
{
    /// <summary>
    /// Interaction logic for DetailsPage.xaml
    /// </summary>
    public partial class DetailsPage : Page
    {
        private readonly string _moreInfoURL;

        public DetailsPage(CarouselItem item)
        {
            InitializeComponent();

            TitleText.Text = item.Title;
            SubtitleText.Text = item.Subtitle;
            InfoBlurbText.Text = item.InfoBlurb;
            ActiveEraText.Text = item.ActiveEra;
            PrimaryLocation.Text = item.PrimaryLocation;

            PortraitImage.Source = new BitmapImage(new Uri(item.ImagePath, UriKind.RelativeOrAbsolute));
            _moreInfoURL = item.wikiURL;
        }

        private void Back_Home(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
        private void More_Info(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_moreInfoURL))
            {
                try
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = _moreInfoURL,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch
                {
                    MessageBox.Show("Unable to open link.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
