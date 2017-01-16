using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace ImageTest.UWP
{
    public class MainViewModel
    {
        public ObservableCollection<Model> items;
        public MainViewModel()
        {
            items = new ObservableCollection<Model>();
        }
    }
    public class Model
    {
        public string imageSource { get; set; }
    }
}
