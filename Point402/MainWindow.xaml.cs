using Microsoft.Win32;
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
using Point402.View;
using System.Windows.Media.Animation;

namespace Point402
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation tbAnimation = new DoubleAnimation();
            tbAnimation.From = TBHello.ActualWidth;
            tbAnimation.To = 320;
            tbAnimation.Duration = TimeSpan.FromSeconds(1.5);
            TBHello.BeginAnimation(TextBlock.WidthProperty, tbAnimation);
        }

        private void btnRacer_Click(object sender, RoutedEventArgs e)
        {
            WinAutorization winAutorization = new WinAutorization();
            winAutorization.Show();
            this.Close();

        }
        private void btnView_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnExit1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
