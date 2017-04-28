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

namespace Main_page
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page_6 : Page
    {
        public Page_6()
        {
            this.InitializeComponent();
        }
        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page_7));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page_5));
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Menu_DropDownChange(object sender, SelectionChangedEventArgs e)
        {
            if (BackToMain.IsSelected)
            {
                Frame.Navigate(typeof(MainPage));
            }
            else if (Credits.IsSelected)
            {
                Frame.Navigate(typeof(CreditsPage));
            }
        }
    }
}
