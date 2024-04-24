using System;
using System.Reflection.Emit;
using Xamarin.Forms;

namespace Mono.Samples.HelloWorld.Resources
{
    public class LoginPage
    {
        
    }
    public partial class BasicButtonClickPage : ContentPage
    {
        public BasicButtonClickPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await label.RelRotateTo(360, 1000);
        }
    }
}
