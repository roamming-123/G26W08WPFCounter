using System.Windows;


namespace G26W08WPFCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected int Count = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            TxtCount.Text = $"{++Count}";
        }
        
        private void OnMinus(object sender, RoutedEventArgs e)
        {
            TxtCount.Text = $"{--Count}";
        }

    }
}