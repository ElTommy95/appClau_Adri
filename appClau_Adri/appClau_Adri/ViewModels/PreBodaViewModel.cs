namespace appClau_Adri.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class PreBodaViewModel
    {
        #region PROPIEDADES
        public bool IsRecordar
        {
            get;
            set;
        }
        #endregion

        #region CONSTRUCTOR
        public PreBodaViewModel()
        {
            this.IsRecordar = true;
        }
        #endregion

        #region PROPIEDADE DE LOS COMANDOS
        public ICommand Btn_AGaleria
        {
            get
            {
                return new RelayCommand(BtnAGaleria);
            }
        }

        private async void BtnAGaleria()
        {
            MainViewModel.GetInstance().GaleriaPreboda = new GaleriaPrebodaViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new GaleriaPrebodaPage());
            //await Application.Current.MainPage.DisplayAlert(
            //    "Bien Ahi :)",
            //    "Si Funciona!!!",
            //    "Aceptar");
        }
        #endregion
    }
}
