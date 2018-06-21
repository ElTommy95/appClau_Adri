using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using appClau_Adri.Views;

namespace appClau_Adri.ViewModels
{
    public class ClaudiaViewModel
    {
        #region Las Propiedades de los COMANDOS
        public ICommand Btn_Recuerdos
        {
            get
            {
                return new RelayCommand(BtnRecuerdos);
            }
        }

        private void BtnRecuerdos()
        {
            MainViewModel.GetInstance().Fotos= new FotosViewModel();
            Application.Current.MainPage = new FotosPage();
        }
        #endregion
    }
}
