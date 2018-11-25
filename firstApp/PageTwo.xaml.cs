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
    /// Interaction logic for PageTwo.xaml
    /// </summary>
    public partial class PageTwo : Page
    {
        public List<uint> message { get; set; }

        public PageTwo(List<uint> message_block)
        {
            InitializeComponent();

            Hasher h = new Hasher();
            message_block = h.Pad_to_512bits(message_block);
            Padding.Text = h.Padding(message_block);
            message = message_block;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Next2_Click(object sender, RoutedEventArgs e)
        {
            Next2.Visibility = Visibility.Hidden;
            InputData.Text = "64 bit representation of l is then appended to the end";
        }

        private void Next1_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new PageThree(message));
        }
    }
}
