﻿using System;
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
using WPFLibrary.VM;

namespace WPFLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vModel;
        public MainWindow()
        {
            vModel = new();
            InitializeComponent();
            DataContext = vModel;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if ((sender as Button)?.Content.ToString() == "Next") vModel.SelectedIndex++;
            else vModel.SelectedIndex--;
            bookList.ScrollIntoView(vModel.SelectionBook);
        }
    }
}
