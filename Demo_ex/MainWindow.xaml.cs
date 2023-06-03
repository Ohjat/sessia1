using Demo_ex.bd.sessia1DataSetTableAdapters;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Demo_ex
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            FrameAvtorisate.Navigate(new autorisate());
        }
       
    }
}
