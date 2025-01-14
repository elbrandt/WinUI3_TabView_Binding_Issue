using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TabViewDemo
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainViewModel ViewModel = new();
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {
            //ViewModel.Tabs.Add(new TabViewModel());
        }

        private void TabCloseRequested(TabView sender, TabViewTabCloseRequestedEventArgs args)
        {
            ViewModel.Tabs.Remove(args.Item as TabViewModel);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            // this is being done from a button as proof that it works.
            // there are cleaner ways and places to do this in real code.
            foreach (var t in tabView.TabItems)
            {
                var d = this.tabView.ContainerFromItem(t);
                ((MyControl)((TabViewItem)d).Content).UpdateBindings();
            }
        }
    }
}
