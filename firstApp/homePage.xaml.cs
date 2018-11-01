using System;
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
    /// Interaction logic for homePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            string rnd = rand.Next(999999999).ToString() + rand.Next(999999999).ToString() + rand.Next(999999999).ToString() + rand.Next(999999999).ToString();
            string str = rnd.ToString();
            hash.Text = str;
        }

        private void Tutorial_Click(object sender, RoutedEventArgs e)
        {
            PageOne pageOne = new PageOne();
            NavigationService.Navigate(pageOne);
                        
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (hash == null) return;
            Generate_Click(null, null);
        }
    }
}
