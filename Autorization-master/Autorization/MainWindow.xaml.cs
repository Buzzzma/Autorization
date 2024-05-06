using System;
using System.Collections.Generic;
using System.IO;
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

namespace Autorization {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool flag = true;
            foreach (Person user in Users.GetUsers())
                      {
                          if (login.Text == user.Name)
                          { 
                              flag = false;   
                              Singleton.var = user.Name;
                              Window1 window1 = new Window1();
                              window1.Show();
                              Close();
                          }
                      }
            if(flag) MessageBox.Show("Нет такого пользователя!😡");
        }

        private void Delete_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}
