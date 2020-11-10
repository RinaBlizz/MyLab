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

namespace OperCatch1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                byte n= byte.Parse(Month.Text);
                switch(n)
                {
                    case 1: Result.Content = "Зима"; break;
                    case 2: Result.Content = "Зима"; break;
                    case 3: Result.Content = "Весна"; break;
                    case 4: Result.Content = "Весна"; break;
                    case 5: Result.Content = "Весна"; break;
                    case 6: Result.Content = "Лето"; break;
                    case 7: Result.Content = "Лето"; break;
                    case 8: Result.Content = "Лето"; break;
                    case 9: Result.Content = "Осень"; break;
                    case 10: Result.Content = "Осень"; break;
                    case 11: Result.Content = "Осень"; break;
                    case 12: Result.Content = "Зима"; break;
                    default: Result.Content = "Неправильно введены данные"; break;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
