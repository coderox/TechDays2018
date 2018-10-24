using System.Windows.Forms;

using Microsoft.Toolkit.Forms.UI.XamlHost;
using Microsoft.Toolkit.Win32.UI.XamlHost;

namespace XamlIslands.WinForms
{
    public partial class Form1 : Form
    {
        Windows.UI.Xaml.Controls.Button uwpButton;

        public Form1()
        {
            InitializeComponent();

            UseHelperMethod();
        }

        private void UseHelperMethod()
        {
            var myHostControl = new WindowsXamlHost();
            myHostControl.Dock = DockStyle.Fill;

            // Use helper method to create a UWP control instance.
            uwpButton =
                UWPTypeFactory.CreateXamlContentByType("Windows.UI.Xaml.Controls.Button")
                as Windows.UI.Xaml.Controls.Button;

            // Initialize UWP control.
            uwpButton.Name = "button1";
            uwpButton.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch;
            uwpButton.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch;
            uwpButton.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Red);
            uwpButton.Click += delegate { uwpButton.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Blue); };

            // initialize the Windows XAML host control.
            myHostControl.Name = "myWindowsXamlHostControl";
            myHostControl.Child = uwpButton;

            // Make the UWP control appear in the UI.
            this.Controls.Add(myHostControl);
        }
    }
}
