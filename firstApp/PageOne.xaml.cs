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
    /// Interaction logic for tut1.xaml
    /// </summary>
    public partial class PageOne : Page
    {
        public PageOne(string str)
        {
            InitializeComponent();
            Conversion.Text = str;
        }

        internal new static void RequestBringIntoViewEvent()
        {
            //throw new NotImplementedException();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            PageTwo pageTwo = new PageTwo();
            NavigationService.Navigate(pageTwo);
            
        }


    }
}
