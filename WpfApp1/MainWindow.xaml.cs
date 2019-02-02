using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static HttpClient client = new HttpClient();

        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitilizeClient();
        }

        private async Task LoadJoke()
        {
            var joke = await JokeProcessor.LoadJoke();
            infoTextBox.Text = joke.Joke;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await LoadJoke();
        }
    }
}

