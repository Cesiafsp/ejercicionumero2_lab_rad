using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicionumero2_lab_rad.Views

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAlums : ContentPage
    {
        public PageAlums()
        {
            InitializationFlags();

        }
        private async void btnmostrar_Clicked(object sender, EventArgs e)
        {
            var alum = new Models.alumno
            {
                numero1 = txtNumerouno.Text,
                numero2 = txtNumerodos.Text,
               

            };

            var page = new Views.PageResultado();
            page.BindingContext = alum;
            await Navigation.PushAsync(page);


        }
    }
}