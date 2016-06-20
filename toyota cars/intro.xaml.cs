using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace toyota_cars
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class intro : Page
    {
        public intro()
        {
            this.InitializeComponent();
            
        }

       

        private void iTunesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(carone));
        }

        private void iTunesButton1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(carone));
        }

        private void iTunesButton3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(carone));

        }

        private void iTunesButton3_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(carone));

        }

        private void iTunesButton4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(carone));

        }

        private void iTunesButton5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(carone));

        }
    }
}
