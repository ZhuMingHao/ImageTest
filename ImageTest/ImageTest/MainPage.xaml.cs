using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var embeddedImage = new Image { Aspect = Aspect.AspectFill };
            embeddedImage.Source = ImageSource.FromResource("ImageTest.hello.jpg");
          //  Content = embeddedImage;
        }
    }
}
