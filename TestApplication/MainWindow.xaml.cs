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
    using System.Data.SqlClient;
    using System.Data;

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

        public static string connectionString;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable BarcodesTable;
        public static SqlConnection connection;

        public static string currentBarcode;

        public MainWindow()
        {
            this.InitializeComponent();

            this.DataContext = new MainWindowViewModel();

            connectionString = "server =" + Properties.Settings.Default.Server + 
                               "; database =" + Properties.Settings.Default.DataBase+
                               "; user id ="+ Properties.Settings.Default.User +
                               "; password =" + Properties.Settings.Default.Pwd + 
                               "; connection timeout = 30";

            connection = new SqlConnection(connectionString);
            BarcodesTable = new DataTable();

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
            currentBarcode = data;
            NiceLabel.SDK.MainWindowViewModel.BarcodeUP(data);
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

        private void checkBox_trans_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox_trans.IsChecked == true)
            {
                checkBox_individual.IsChecked = false;
                checkBox_individualWY.IsChecked = false;
            }
        }

        private void checkBox_individual_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox_individual.IsChecked == true)
            {
                checkBox_trans.IsChecked = false;
                checkBox_individualWY.IsChecked = false;
            }
        }

        private void checkBox_individualWY_Click(object sender, RoutedEventArgs e)
        {
            if(checkBox_individualWY.IsChecked==true)
            {
                checkBox_trans.IsChecked = false;
                checkBox_individual.IsChecked = false;
            }
        }

        private void tb_findBarcode_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            bool CanContinue = true;

            if(checkBox_trans.IsChecked == true)
            {
                string sql = "select Артикул,НаименованиеПолное,ЕденицаИзмерения,Количество,Штрихкод from NiceLabel where Артикул LIKE '" +
                                tb_findBarcode.Text + "%' and Количество >1;";
                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                if (connection.State != ConnectionState.Open)
                {
                    try 
                    {
                        connection.Open();
                    }
                    catch(System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        CanContinue = false;
                    }
                }

                if (CanContinue)
                {
                    BarcodesTable.Clear();
                    adapter.Fill(BarcodesTable);
                    dataGrid_barcodes.ItemsSource = BarcodesTable.DefaultView;
                }
            }
            else if (checkBox_individual.IsChecked == true || checkBox_individualWY.IsChecked ==true)
            {

            }
            else
            {
                MessageBox.Show("Не выбран тип этикетки!", "Предупреждение");
                tb_findBarcode.Text = "";
            }  
        }

        private void dataGrid_barcodes_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            System.Windows.Controls.TextBlock art = dataGrid_barcodes.Columns[0].GetCellContent(dataGrid_barcodes.SelectedItem) as System.Windows.Controls.TextBlock;
            System.Windows.Controls.TextBlock name = dataGrid_barcodes.Columns[1].GetCellContent(dataGrid_barcodes.SelectedItem) as System.Windows.Controls.TextBlock;
            System.Windows.Controls.TextBlock count = dataGrid_barcodes.Columns[3].GetCellContent(dataGrid_barcodes.SelectedItem) as System.Windows.Controls.TextBlock;
            System.Windows.Controls.TextBlock barcode = dataGrid_barcodes.Columns[4].GetCellContent(dataGrid_barcodes.SelectedItem) as System.Windows.Controls.TextBlock;

            
            int mode = 0;

            if (checkBox_trans.IsChecked == true)
            {
                mode = 0;
            }
            else if (checkBox_individual.IsChecked==true)
            {
                mode = 1;
            }
            else
            {
                mode = 2;
            }

            NiceLabel.SDK.MainWindowViewModel.BarcodeChoose(name.Text,art.Text, barcode.Text, System.Convert.ToInt32(count.Text),mode,(NiceLabel.SDK.MainWindowViewModel)DataContext);
        }
    }
}
