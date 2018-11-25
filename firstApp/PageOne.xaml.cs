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
        public List<uint> message_block { get; set; }
        public string passStr { set; get; }
        Hasher h = new Hasher();

        public PageOne(string str, List<uint> message)
        {
            
            message_block = message;
            passStr = str;
            InitializeComponent();

            if(passStr.Length > 72)
            {
            ScrollViewer viewer = new ScrollViewer();
            viewer.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            }

            string result = "";

            foreach (char c in str)
                result += (Convert.ToString(c, 2).PadLeft(8, '0'));

            Conversion.Text = result + 1;
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
            message_block = h.Store_input(passStr);
            NavigationService.Navigate(new PageTwo(message_block));
        }


    }
}
