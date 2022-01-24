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
    /// Логика взаимодействия для WinAutorization.xaml
    /// </summary>
    public partial class WinAutorization : Window
    {
        public WinAutorization()
        {
            InitializeComponent();
        }

        private void btnEnterAut_Click(object sender, RoutedEventArgs e)
        {
            if (TBLogin.Text == "111" && TBPassword.Password.ToString() == "111")
            {
                MenuWin menuWin = new MenuWin();
                menuWin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не вошли!!!", "Проблема");
            }
        }
        private void btnExitAut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            
        }
        
    }
}
