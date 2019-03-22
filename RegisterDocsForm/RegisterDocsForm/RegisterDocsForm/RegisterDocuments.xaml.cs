using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RegisterDocsForm
{
    public partial class RegisterDocuments : ContentPage
    {
        public RegisterDocuments()
        {
            InitializeComponent();
            //btnSecondPage.Clicked += (sender, e) =>
            //{
            //    Navigation.PushAsync(new SecondPage()); 
            //};
        }

        private void btnDriverLicense_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new SecondContentPage());
            Navigation.PushAsync(new DriverLicenseDoc());
            //Navigation.PushModalAsync(new SecondPage()); //On top of this, all pages also supports PushModalAsync() which just push a new page on top of the existing one.

        }

        private void btnSoat_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new SecondContentPage());
            Navigation.PushAsync(new SoatDoc());
            //Navigation.PushModalAsync(new SecondPage()); //On top of this, all pages also supports PushModalAsync() which just push a new page on top of the existing one.

        }
    }
}
