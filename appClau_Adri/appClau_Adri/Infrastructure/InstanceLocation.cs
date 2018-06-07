namespace appClau_Adri.Infrastructure
{
    using ViewModels;

    public class InstanceLocation
    {
        // Region de las ViewModels =)
        public MainViewModel Main
        {
            get;
            set;
        }


        // Region de los Constructores =)
        public InstanceLocation()
        {
            this.Main = new MainViewModel();
        }
    }
}
