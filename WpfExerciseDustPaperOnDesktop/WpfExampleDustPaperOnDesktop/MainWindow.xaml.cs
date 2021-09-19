namespace WpfExampleDustPaperOnDesktop
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            // ウィンドウを最小化します
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            // ウィンドウを最大化します
            this.WindowState = WindowState.Maximized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // このウィンドウを閉じます
            this.Close();
        }
    }
}
