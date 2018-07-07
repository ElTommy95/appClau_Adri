namespace appClau_Adri.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class MainViewModel
    {
        #region Propiedades de ObservableCollection
        public ObservableCollection<MenuItemViewModel> Menus
        {
            get;
            set;
        }
        #endregion

        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        public ClaudiaViewModel Claudia
        {
            get;
            set;
        }
        public PreBodaViewModel PreBoda
        {
            get;
            set;
        }
        public GaleriaPrebodaViewModel GaleriaPreboda
        {
            get;
            set;
        }
        #endregion

        #region Constructores
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }
        #endregion

        #region Metodos
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_settings",
                PageName = "NovioPage",
                Title = "Mi Perfil"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_photo_camera",
                PageName = "RecuerdosPage",
                Title = "Mis Fotos"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_videos",
                PageName = "VideosPage",
                Title = "Mis Videos"
            });

        }
        #endregion

        #region Patron Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion

    }
}
