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
namespace Demo_ex.page
{
    /// <summary>
    /// Логика взаимодействия для SelectSurse.xaml
    /// </summary>
    public partial class SelectSurse : Page
    {
        public SelectSurse()
        {
            
            InitializeComponent();
            resurs.ItemsSource = skillTable.GetData();
            boxskill.ItemsSource = akillblokadapter.GetData();
            boxskill.DisplayMemberPath = "title";

        }
        _skill_TableAdapter skillTable = new _skill_TableAdapter();
        _skill_block_TableAdapter akillblokadapter = new _skill_block_TableAdapter();

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var title = boxtitle.Text;
            var skill = boxskill.SelectedIndex;
            var future = double.Parse(boxfuture.Text);
            object id = (resurs.SelectedItem as DataRowView).Row[0];
            skillTable.UpdateQuery(title, skill , future , Convert.ToInt32(id));


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminPage());
        }


    }
}
