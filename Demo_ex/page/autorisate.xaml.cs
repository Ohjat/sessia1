using System;
using System.Collections.Generic;
using System.Data;
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
using Demo_ex.bd.sessia1DataSetTableAdapters;
using Sentry;
using VisioForge.MediaFramework.ONVIF;

namespace Demo_ex
{

    /// <summary>
    /// Логика взаимодействия для autorisate.xaml
    /// </summary>
    public partial class autorisate : Page
    {
        usersTableAdapter usersAdapter = new usersTableAdapter();

        public autorisate()
        {
            InitializeComponent();

            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (log.Text == "" || pass.Password == "")
            {
                MessageBox.Show("Пароль или логин пуст");
                return;
            }

            var user = usersAdapter.AutorisateUser(log.Text, pass.Password);

            if (user.Count == 0)
            {
                MessageBox.Show("не существует");
                return;
            }


            if (user[0].ID_role == 1)
            {
                MessageBox.Show("вы user");
                this.NavigationService.Navigate(new UserPage());
                return;
            }

            MessageBox.Show("вы админ");
            this.NavigationService.Navigate(new AdminPage());


        }


    }
}
