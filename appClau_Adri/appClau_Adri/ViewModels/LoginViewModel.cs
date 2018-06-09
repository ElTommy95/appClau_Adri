namespace appClau_Adri.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;
    using appClau_Adri.Views;

    public class LoginViewModel
    {
        #region Propiedades
        public string Txt_user
        {
            get;
            set;
        }
        public string Txt_passw
        {
            get;
            set;
        }
        public bool IsRecordar
        {
            get;
            set;
        }
        public bool IsAbilitado
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsAbilitado = true;
            this.IsRecordar = true;
        }
        #endregion

        #region Propiedades de los Comandos
        public ICommand Btn_Login
        {
            get
            {
                return new RelayCommand(BtnLogin);
            }
        }

        private void BtnLogin()
        {
            //MainViewModel.GetInstance().Claudia = new ClaudiaViewModel();
            //await Application.Current.MainPage.Navigation.PushAsync(new ClaudiaPage());
            MainViewModel.GetInstance().Claudia = new ClaudiaViewModel();
            Application.Current.MainPage = new MasterPage();
        }
        #endregion
    }
}
