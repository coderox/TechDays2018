using System;
using System.Collections.Generic;
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

namespace XamlIslands.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Windows.UI.Xaml.Controls.Button uwpButton;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnChildChanged(object sender, EventArgs e)
        {
            if (uwpButton == null)
            {
                uwpButton = ((Microsoft.Toolkit.Wpf.UI.XamlHost.WindowsXamlHost)sender).Child as Windows.UI.Xaml.Controls.Button;
                uwpButton.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
                uwpButton.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch;
                uwpButton.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Red);
                uwpButton.Click += delegate { uwpButton.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Blue); };
            }
        }
    }
}
