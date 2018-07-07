namespace appClau_Adri.Views
{
    using System.Collections.Generic;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GaleriaPrebodaPage : ContentPage
    {       
        public GaleriaPrebodaPage ()
		{
			InitializeComponent ();

            var listaImagens = new List<string>
            {
                "Pak_Pentagonito.jpg",
                "Pak_Studio.jpg",
                "Pak_Playa.jpg"
            };
            ImageCarouselView.ItemsSource = listaImagens;
        }
    }
}