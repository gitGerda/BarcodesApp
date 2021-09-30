//-----------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Euro Plus">
//     Copyright © Euro Plus 2014.
// </copyright>
// <summary>This is the MainWindow Window.</summary>
//-----------------------------------------------------------------------
namespace NiceLabel.SDK.DemoApp
{
    using System.Windows;
    using System.IO.Ports;

    /// <summary>
    /// Interaction logic for MainWindow Window.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>

        SerialPort _serialPort;

        public MainWindow()
        {
            this.InitializeComponent();

            this.DataContext = new MainWindowViewModel();

            //string f = Properties.Settings.Default.ComPort;

            //Properties.Settings.Default.ComPort = "Test2";
            //Properties.Settings.Default.Save();

            //f= Properties.Settings.Default.ComPort;
        }
    }
}
