﻿using System.Windows;
using System.Windows.Controls;
namespace WpfTrading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
        }


        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
           

        }


        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {

        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = ((ComboBox)sender).SelectedValue;
            var comboItem = ((ComboBoxItem)combo).Content;           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
