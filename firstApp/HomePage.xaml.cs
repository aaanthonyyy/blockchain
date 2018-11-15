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
        public string PassStr { get; set; }

        Hasher h = new Hasher();
        List<ulong> message_block = new List<ulong>();

        public HomePage()
        {
            InitializeComponent();

            PassStr = Input.Text;
        }


        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            if (hash == null) return;
            PassStr  = Input.Text;

            message_block = (h.Store_input(PassStr));
            message_block = h.Pad_to_512bits(message_block);
            message_block = h.Resize_block(message_block);

            string str = h.Compute_hash(message_block);

            hash.Text = str;
        }

        private void Tutorial_Click(object sender, RoutedEventArgs e)
        {


            this.NavigationService.Navigate(new PageOne(PassStr, message_block));
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (hash == null) return;
            Generate_Click(null, null);
            PassStr = Input.Text;
        }
    }
}
