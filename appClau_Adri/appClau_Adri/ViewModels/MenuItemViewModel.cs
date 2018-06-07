namespace appClau_Adri.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class MenuItemViewModel
    {
        public string Icon
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string PageName
        {
            get;
            set;
        }

        //Region de las Propiedades de Comandos
        public ICommand NavegaPes
        {
            get
            {
                return new RelayCommand(Navega);
            }
        }

        private  void Navega()
        {
            if (this.PageName == "NovioPage")
            {
                //MainViewModel.GetInstance().Novio = new NovioViewModel();
                //Application.Current.MainPage = new MasterPage();
            }
            if (this.PageName == "RecuerdosPage")
            {
                //MainViewModel.GetInstance().Recuerdos = new RecuerdosViewModel();
                //await App.Navigator.PushAsync(new RecuerdosPage());
            }
            if (this.PageName == "VideosPage")
            {
                //MainViewModel.GetInstance().Videos = new VideosViewModel();
                //await App.Navigator.PushAsync(new VideosPage());
            }
        }
    }
}
