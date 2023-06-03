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
using Demo_ex.bd.sessia1DataSetTableAdapters;

namespace Demo_ex.page
{




    /// <summary>
    /// Логика взаимодействия для UpdateSurse.xaml
    /// </summary>
    public partial class UpdateSurse : Page
    {
        _skill_TableAdapter skilladapter = new _skill_TableAdapter();
        _skill_block_TableAdapter skilblokadapter = new _skill_block_TableAdapter();
        public UpdateSurse()
        {
            InitializeComponent();
            var dataadapty = skilblokadapter.GetData();
            boxskill.ItemsSource = dataadapty;
            boxskill.DisplayMemberPath = "title";                  
        }

        private void BTNSave_Click(object sender, RoutedEventArgs e)
        {
            var title = boxtitle.Text;
            var skill = boxskill.SelectedIndex;
            var future = double.Parse(boxfuture.Text);
            skilladapter.InsertQuery(title, skill, future);          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminPage());
        }
    }
}
