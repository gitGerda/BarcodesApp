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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace NiceLabel.SDK
{
    /// <summary>
    /// Логика взаимодействия для WindowSettings.xaml
    /// </summary>
    public partial class WindowSettings : Window
    {
        public WindowSettings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tb_ComPort.Text = Properties.Settings.Default.ComPort;
            tb_Server.Text = Properties.Settings.Default.Server;
            tb_Db.Text = Properties.Settings.Default.DataBase;
            tb_User.Text = Properties.Settings.Default.User;
            tb_Pwd.Text = Properties.Settings.Default.Pwd;
        }

        private void tb_ComPort_TextChanged(object sender, TextChangedEventArgs e)
        {
            Properties.Settings.Default.ComPort = tb_ComPort.Text;
            Properties.Settings.Default.Save();
        }

        private void tb_Server_TextChanged(object sender, TextChangedEventArgs e)
        {
            Properties.Settings.Default.Server = tb_Server.Text;
            Properties.Settings.Default.Save();
        }

        private void tb_Db_TextChanged(object sender, TextChangedEventArgs e)
        {
            Properties.Settings.Default.DataBase = tb_Db.Text;
            Properties.Settings.Default.Save();
        }

        private void tb_User_TextChanged(object sender, TextChangedEventArgs e)
        {
            Properties.Settings.Default.User = tb_User.Text;
            Properties.Settings.Default.Save();
        }

        private void tb_Pwd_TextChanged(object sender, TextChangedEventArgs e)
        {
            Properties.Settings.Default.Pwd = tb_Pwd.Text;
            Properties.Settings.Default.Save();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string ConnectionStr = "server =" + tb_Server.Text + "; database =" + tb_Db.Text + "; user id ="
                                                               + tb_User.Text + "; password =" + tb_Pwd.Text + "; connection timeout = 30";

            SqlConnection connection = new SqlConnection(ConnectionStr);
            try
            {
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Соединение с базой данных успешно установлено!");
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка соединения с базой данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
