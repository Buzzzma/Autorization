using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Autorization {
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        private CollectionViewSource collectionViewSource;
        public Window1() {
            InitializeComponent();
            foreach (Person user in Users.GetUsers())
            {
                if (Singleton.var == user.Name)
                {
                    avatar.Source = new BitmapImage(new Uri(@"D:\ис21\Autorization-master\Autorization-master\Autorization\" + user.UriPath));
                    name_acc.Text = $"{user.Surname} {user.Name} {user.Fathername}";
                    role_acc.Text = user.Role;
                }
            }


            List<Person> withoutMeUsers = new List<Person>();
            foreach (Person user in Users.GetUsers())
            {
                if (user.Name != Singleton.var)
                {
                    withoutMeUsers.Add(user);
                }
            }


            collectionViewSource = new CollectionViewSource
            {
                Source = withoutMeUsers
            };

            users.ItemsSource = collectionViewSource.View;

        }

        private void Return_Click(object sender, RoutedEventArgs e) {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e) {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if(search_tb.Width == 0)
            {
                search_tb.Width = 200;
            }else search_tb.Width = 0;
        }

        private void search_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            ICollectionView view = collectionViewSource.View;

            // Применяем фильтр
            string searchText = search_tb.Text.ToLower();
            view.Filter = (item) => ((Person)item).Name.ToLower().Contains(searchText);
        }
    }
}
