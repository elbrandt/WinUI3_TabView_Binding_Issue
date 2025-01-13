using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace TabViewDemo
{
    public partial class MainViewModel
    {
        private static int _globalCounter = 0;
        public ObservableCollection<TabViewModel> Tabs = [];

        [RelayCommand]
        private async Task TestAdd()
        {
            Tabs.Add(new TabViewModel(++_globalCounter));
        }
    }

    public class TabViewModel
    {

        public TabViewModel(int number)
        {
            MyNumber = number;

        }


        public int MyNumber { get; }

    }
}
