using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class Page_2 : Page
    {
        public Page_2()
        {
            this.InitializeComponent();

            FirstBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
            SecondBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
            ThirdBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page_3));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page1));
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

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            SoundOne.Play();
            FirstBorder.BorderBrush = new SolidColorBrush(Colors.Black);
        }

        private void SoundTwoPlayer_Click(object sender, RoutedEventArgs e)
        {
            FirstBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
            SecondBorder.BorderBrush = new SolidColorBrush(Colors.Black);
            SoundTwo.Play();

        }

        private void SoundThreePlayer_Click(object sender, RoutedEventArgs e)
        {
            SecondBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
            ThirdBorder.BorderBrush = new SolidColorBrush(Colors.Black);
            SoundThree.Play();
        }
    }
}
