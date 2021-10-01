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
    using System.Threading;
    using System.Windows.Threading;

    /// <summary>
    /// Interaction logic for MainWindow Window.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>

        SerialPort _serialPort;
        private delegate void SetTextDeleg(string text);

        public MainWindow()
        {
            this.InitializeComponent();

            this.DataContext = new MainWindowViewModel();

        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            WindowSettings WSett = new WindowSettings();

            string CurrComPort = Properties.Settings.Default.ComPort;

            WSett.ShowDialog();

            if (CurrComPort != Properties.Settings.Default.ComPort)
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
                OpenComPort();
            }  
            
        }

        public void sp_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);

            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            this.Dispatcher.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { indata });
        }

        public void si_DataReceived(string data)
        {
            tb_scaner.Text = data;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OpenComPort();
        }

        public void OpenComPort() 
        {
            try
            {
                _serialPort = new SerialPort(Properties.Settings.Default.ComPort);
                _serialPort.Handshake = Handshake.None;
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataRecieved);
                _serialPort.WriteTimeout = 500;

                _serialPort.Open();
            }
            catch
            {
                MessageBox.Show("Не удалось подключить сканер штрихкодов.");
            }
        }

    }
}
