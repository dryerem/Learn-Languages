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

namespace FirstLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _password = "qwerty";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAuthClick(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text != string.Empty)
            {
                if (PasswordTextBox.Text == _password)
                {
                    MessageBox.Show("Поздравляю! Вы верно ввели пароль!");
                }
                else
                {
                    MessageBox.Show("Неправильный пароль!");
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели пароль!");
            }
        }
    }
}
