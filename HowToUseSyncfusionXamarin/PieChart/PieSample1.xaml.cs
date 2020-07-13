using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfChart.XForms;
using Xamarin.Forms;

namespace HowToUseSyncfusionXamarin
{
    public partial class PieSample1 : ContentPage
    {
        public PieSample1()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            this.BindingContext = new PieChartViewModel();
        }
    }
}
