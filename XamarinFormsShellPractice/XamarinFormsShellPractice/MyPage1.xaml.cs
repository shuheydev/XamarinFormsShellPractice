using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsShellPractice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPage1 : ContentPage
    {
        public MyPage1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var mp2 = new MyPage2();
            Shell.SetTabBarIsVisible(mp2, false);
            await Shell.Current.Navigation.PushAsync(mp2, true);
        }
    }
}