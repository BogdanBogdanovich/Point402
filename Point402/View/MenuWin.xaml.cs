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

namespace Point402.View
{
    /// <summary>
    /// Логика взаимодействия для MenuWin.xaml
    /// </summary>
    public partial class MenuWin : Window
    {
        public MenuWin()
        {
            InitializeComponent();
        }
        private void OpenRacer(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RacerPage());
            if (btnRacerInfo.Visibility == Visibility.Collapsed)
            {
                btnRacerInfo.Visibility = Visibility.Visible;
                btnRacerCar.Visibility = Visibility.Visible;
                btnRacer.Background = Brushes.Gray;
                btnRacer.Foreground = Brushes.LightGray;
            }
            else if (btnRacerInfo.Visibility == Visibility.Visible)
            {
                btnRacerInfo.Visibility = Visibility.Collapsed;
                btnRacerCar.Visibility = Visibility.Collapsed;
                btnRacer.Background = Brushes.White;
                btnRacer.Foreground = Brushes.Gray;
            }
        }
        private void OpenCar(object sender, RoutedEventArgs e)
        {
            if (btnCarInfo.Visibility == Visibility.Collapsed)
            {
                btnCarInfo.Visibility = Visibility.Visible;
                btnCarRivals.Visibility = Visibility.Visible;
                btnCar.Background = Brushes.Gray;
                btnCar.Foreground = Brushes.LightGray;
            }
            else if (btnCarInfo.Visibility == Visibility.Visible)
            {
                btnCarInfo.Visibility = Visibility.Collapsed;
                btnCarRivals.Visibility = Visibility.Collapsed;
                btnCar.Background = Brushes.White;
                btnCar.Foreground = Brushes.Gray;
            }
            
        }

        private void btnExit2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClose1_Click(object sender, RoutedEventArgs e)
        {
            if (winMenu.WindowState == WindowState.Normal)
            {
                winMenu.WindowState = WindowState.Maximized;
            }
            else if (winMenu.WindowState == WindowState.Maximized)
            {
                winMenu.WindowState = WindowState.Normal;
            }
        }

        private void btnClose2_Click(object sender, RoutedEventArgs e)
        {
            if (winMenu.WindowState == WindowState.Normal || winMenu.WindowState == WindowState.Maximized)
            {
                winMenu.WindowState = WindowState.Minimized;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cd1.Width = GridLength.Auto;
        }
    }
}
