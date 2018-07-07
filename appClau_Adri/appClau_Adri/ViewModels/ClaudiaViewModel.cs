namespace appClau_Adri.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class ClaudiaViewModel
    {

        #region Las Propiedades de los COMANDOS
        public ICommand Btn_AFotos
        {
            get
            {
                return new RelayCommand(BtnAFotos);
            }
        }

        private void BtnAFotos()
        {
            MainViewModel.GetInstance().PreBoda= new PreBodaViewModel();
            Application.Current.MainPage = new NavigationPage(new FotosPage());
        }
        #endregion
    }
}