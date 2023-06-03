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
using Demo_ex.page;

namespace Demo_ex
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {

        _skill_TableAdapter tibleadapter = new _skill_TableAdapter();

        public AdminPage()
        {
            InitializeComponent();
            Dannie.ItemsSource = tibleadapter.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new UpdateSurse());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SelectSurse());

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (Dannie.SelectedItem as DataRowView).Row[0];
            tibleadapter.DeleteQuery(Convert.ToInt32(id));
        }
    }
}
