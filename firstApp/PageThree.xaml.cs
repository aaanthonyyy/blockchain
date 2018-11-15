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
    /// Interaction logic for PageThree.xaml
    /// </summary>
    public partial class PageThree : Page
    {
        public List<ulong> message { get; set; }

        public PageThree(List<ulong> message_block)
        {
            InitializeComponent();

            Hasher h = new Hasher();
            message_block = h.Resize_block(message_block);


            sWord.Text = h.Word(message_block, 17);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Next.Visibility = Visibility.Hidden;
        }
    }
}
