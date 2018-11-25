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
    /// Interaction logic for PageFive.xaml
    /// </summary>
    public partial class PageFive : Page
    {
        public PageFive(List<uint> message_block)
        {
            InitializeComponent();

            Hasher h = new Hasher();

            string hash = h.Compute_hash(message_block);
            H0.Text = "H0 = " + hash.Substring(0, 8);
            H1.Text = "H1 = " + hash.Substring(8, 8);
            H2.Text = "H2 = " + hash.Substring(16, 8);
            H3.Text = "H3 = " + hash.Substring(24, 8);
            H4.Text = "H4 = " + hash.Substring(32, 8);
            H5.Text = "H5 = " + hash.Substring(40, 8);
            H6.Text = "H6 = " + hash.Substring(48, 8);
            H7.Text = "H7 = " + hash.Substring(56, 8);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            HashComp.Text = "Easter Egg ()";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
