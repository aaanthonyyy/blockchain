﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace firstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HomePage homePage = new HomePage();

        public MainWindow()
        {
            InitializeComponent();
            tutorialScreens.Navigate(homePage);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // Input_TextChanged(Input.Text, null);
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            tutorialScreens.Navigate(homePage);
        }
    }
}
