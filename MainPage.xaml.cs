using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace infokiosk
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Disabled;
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, e) =>
            {
                if (myFrame.CanGoBack)
                    myFrame.GoBack();
            };
        }

        private void menu_click(object sender, RoutedEventArgs e)
        {
            splitview1.IsPaneOpen = !splitview1.IsPaneOpen;
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {


            StackPanel stackMenu = e.ClickedItem as StackPanel;

            
            string menuitem = stackMenu.Tag.ToString();

            
            switch (menuitem)
            {
                case "Tunniplaan":
                    myFrame.Navigate(typeof(tunniplaan));
                    splitview1.IsPaneOpen = false;
                    break;

                case "Bussiajad":
                    myFrame.Navigate(typeof(bussiajad));
                    splitview1.IsPaneOpen = false;
                    break;

                case "Menüü":
                    myFrame.Navigate(typeof(MainPage));
                    splitview1.IsPaneOpen = false;
                    break;

                case "Kontaktid":
                    myFrame.Navigate(typeof(Kontaktid));
                    splitview1.IsPaneOpen = false;
                    break;

                case "Konsultatsioonid":
                    myFrame.Navigate(typeof(MainPage));
                    splitview1.IsPaneOpen = false;
                    break;

                default:
                    break;
            }
        }

        private void back_button(object sender, RoutedEventArgs e)
        {
            {
                if (myFrame.CanGoBack)
                    myFrame.GoBack();
            };
        }
    }
}
