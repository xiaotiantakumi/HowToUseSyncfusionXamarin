using Xamarin.Forms;

namespace HowToUseSyncfusionXamarin.GettingStarted
{
    public partial class GettingStarted3 : ContentPage
    {
        public GettingStarted3()
        {
            InitializeComponent();
            this.BindingContext = new GettingStarted2ViewModel();
        }
    }
}
