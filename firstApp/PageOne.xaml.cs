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
        public PageOne()
        {
            InitializeComponent();
            append.Text = HomePage.ContentProperty.Name;
        }

        internal new static void RequestBringIntoViewEvent()
        {
            throw new NotImplementedException();
        }
    }
}
