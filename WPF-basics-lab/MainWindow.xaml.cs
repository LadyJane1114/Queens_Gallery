using System.Collections.ObjectModel;
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
using Queens_Gallery.Models;

namespace Queens_Gallery
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Models.CarouselItem> Portraits { get; set; }

        private const int VisibleCount = 5;
        private int _currentCenterIndex = 0;

        public ObservableCollection<Models.CarouselItem> VisiblePortraits { get; } = new ObservableCollection<Models.CarouselItem>();

        public MainWindow()
        {
            InitializeComponent();

            Portraits = new ObservableCollection<CarouselItem>
            {
                new CarouselItem
                {
                    Title = "Mary Shelley",
                    ImagePath = "resources/m-shelley.jpg"
                },
                new CarouselItem
                {
                    Title = "Hattie McDaniel",
                    ImagePath = "resources/hattie-mcdaniel.jpg"
                },
                new CarouselItem
                {
                    Title = "Anne Bonny and Mary Read",
                    ImagePath = "resources/anne-and-mary.jpg"
                },
                new CarouselItem
                {
                    Title = "Jane Austen",
                    ImagePath = "resources/jane-austen.jpg"
                },
                new CarouselItem
                {
                    Title = "Boudica",
                    ImagePath = "resources/bouddica.jpg"
                },
                new CarouselItem
                {
                    Title = "Ada Lovelace",
                    ImagePath = "resources/ada-love.jpg"
                },
                new CarouselItem
                {
                    Title = "Joan of Arc",
                    ImagePath = "resources/st-joan-of-arc.jpg"
                },
                new CarouselItem
                {
                    Title = "Frida Kahlo",
                    ImagePath = "resources/frida.jpg"
                },
                new CarouselItem
                {
                    Title = "Hedy Lamarr",
                    ImagePath = "resources/hedy.jpg"
                },
                new CarouselItem
                {
                    Title = "Helen Keller",
                    ImagePath = "resources/KEller_Helen.jpg"
                },
                new CarouselItem
                {
                    Title = "Zora Neale Hurston",
                    ImagePath = "resources/Zora-Neale-Hurston.jpg"
                },
                new CarouselItem
                {
                    Title = "Ruth Handler",
                    ImagePath = "resources/ruth-handler.jpg"
                },
                new CarouselItem
                {
                    Title = "Mary Wollstonecraft",
                    ImagePath = "resources/m-wollestoncraft.jpg"
                },
                new CarouselItem
                {
                    Title = "Hypatia of Alexandria",
                    ImagePath = "resources/hypatia.jpg"
                },
                new CarouselItem
                {
                    Title = "Murasaki Shikibu",
                    ImagePath = "resources/murasaki-shikibu.jpg"
                },
                new CarouselItem
                {
                    Title = "Rosa Parks",
                    ImagePath = "resources/rosa-parks.jpg"
                },
                new CarouselItem
                {
                    Title = "Gráinne Ní Mháille",
                    ImagePath = "resources/grainne.jpg"
                },
                new CarouselItem
                {
                    Title = "Marsha P. Johnson",
                    ImagePath = "resources/marsha.jpg"
                },
                new CarouselItem
                {
                    Title = "Jane Goodall",
                    ImagePath = "resources/jane-goodall.jpg"
                },
                new CarouselItem
                {
                    Title = "Eleanor of Aquitaine",
                    ImagePath = "resources/queen-eleanor.JPG"
                }
            };
            this.DataContext = this;
            UpdateVisiblePortraits();
        }

        private void Carousel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Carousel.SelectedItem is CarouselItem item)
            {
                // Navigate to page details
                MessageBox.Show($"You clicked: {item.Title}");
            }
        }

        private void UpdateVisiblePortraits()
        {
            VisiblePortraits.Clear();

            int half = VisibleCount / 2;
            int total = Portraits.Count;

            for (int offset = -half; offset <= half; offset++)
            {
                int index = (_currentCenterIndex + offset+ total) % total;
                VisiblePortraits.Add(Portraits[index]);
            }
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            _currentCenterIndex--;

            if (_currentCenterIndex < 0)
            {
                _currentCenterIndex = Portraits.Count - 1;
            }
            UpdateVisiblePortraits();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            _currentCenterIndex++;

            if (_currentCenterIndex >= Portraits.Count )
            {
                _currentCenterIndex = 0;
            }
            UpdateVisiblePortraits();
        }
    }
}