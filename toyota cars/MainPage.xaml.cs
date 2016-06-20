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
    public sealed partial class MainPage : Page
    {
        int change = 1;
        DispatcherTimer timer = new DispatcherTimer();
        public MainPage()
        {
           
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
            timer.Tick += timer_tick;
            this.InitializeComponent();
            this.DataContext = itemsss.GetTours();
        }

        private void timer_tick(object sender, object e)
        {
            int newindex = flip.SelectedIndex + change;
            if (newindex >= flip.Items.Count || newindex < 0) { change *= -1; }
            flip.SelectedIndex += change;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(intro));
        }

        


      
    }
}
