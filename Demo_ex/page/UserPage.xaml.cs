using Demo_ex.bd.sessia1DataSetTableAdapters;
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

namespace Demo_ex
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            ColoudData.ItemsSource = user.GetData();
            Combouser.ItemsSource = user.GetData();
            Combouser.DisplayMemberPath = "FIO";
        }
        usersTableAdapter user = new usersTableAdapter();
   

        private void btndELETE_Click(object sender, RoutedEventArgs e)
        {
            object id = (Combouser.SelectedItem as DataRowView).Row[0];
            user.DeleteQuery(Convert.ToInt32(id));
        }


    }
}
