using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms;

namespace ImageTest.UWP
{
    public sealed partial class MainPage
    {
        public MainViewModel viewModel { get; set; }
        public MainPage()
        {
            this.InitializeComponent();      
            viewModel = this.DataContext as MainViewModel;
            viewModel.items.Add(new Model() { imageSource = "ImageTest.hello.jpg" });
            viewModel.items.Add(new Model() { imageSource= "ImageTest.hello.jpg" });
            MyGridView.ItemsSource = viewModel.items;
        }
    }
}
