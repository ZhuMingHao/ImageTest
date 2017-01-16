using ImageTest.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(TestInterface))]
namespace ImageTest.UWP
{
    public class TestInterface : IInterface
    {
        public void run()
        {
            throw new NotImplementedException();
        }
    }
}
