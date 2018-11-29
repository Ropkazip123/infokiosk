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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace infokiosk
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Kontaktid : Page
    {
        public Kontaktid()
        {
            this.InitializeComponent();
            LoadItems();
        }

        private void LoadItems()
        {
            for (int x = 1; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    ListViewItem item = new ListViewItem();
                    
                    if (x == 1)
                    {
                        list1.Items.Add(item);
                        item.Content = "Eesnimi";
                    }
                    else if(x == 2)
                    {
                        list2.Items.Add(item);
                        item.Content = "Perenimi";
                    }
                    else if (x == 3)
                    {
                        list3.Items.Add(item);
                        item.Content = "Email";
                    }
                    else if (x == 4)
                    {
                        list4.Items.Add(item);
                        item.Content = "Tel. number";
                    }
                }
            }
        }
    }
}
