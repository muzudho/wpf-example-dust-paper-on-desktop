namespace WpfExampleDustPaperOnDesktop
{
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Media;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MinimizedButton_Click(object sender, RoutedEventArgs e)
        {
            // ウィンドウを最小化します
            this.WindowState = WindowState.Minimized;
        }

        private void NormalButton_Click(object sender, RoutedEventArgs e)
        {
            // 最大化しているウィンドウを元に戻します
            this.WindowState = WindowState.Normal;
        }

        private void MaximizedButton_Click(object sender, RoutedEventArgs e)
        {
            // ウィンドウを最大化します
            this.WindowState = WindowState.Maximized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // このウィンドウを閉じます
            this.Close();
        }

        /// <summary>
        /// 紙の上でマウスボタンを押下したとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DustPaper_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var coord = ((Visual)sender).PointToScreen(e.GetPosition((IInputElement)sender));
            Trace.WriteLine($"マウスボタンを押下しました。 sender.GetType()=[{sender.GetType()}] x=[{coord.X}] y=[{coord.Y}]");
        }

        private void DustPaper_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var coord = ((Visual)sender).PointToScreen(e.GetPosition((IInputElement)sender));
            Trace.WriteLine($"マウスボタンが離されました。 sender.GetType()=[{sender.GetType()}] x=[{coord.X}] y=[{coord.Y}]");
        }
    }
}
