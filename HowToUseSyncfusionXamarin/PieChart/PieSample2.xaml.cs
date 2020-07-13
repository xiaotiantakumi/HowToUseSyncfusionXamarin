using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfChart.XForms;
using Xamarin.Forms;

namespace HowToUseSyncfusionXamarin
{

    public class PieSample2ViewModel
    {
        public ObservableCollection<PieChartModel> Data { get; set; }

        public PieSample2ViewModel()
        {
            Data = new ObservableCollection<PieChartModel>()
            {
                new PieChartModel("Jan", 50),
                new PieChartModel("Feb", 70),
                new PieChartModel("Mar", 1),
                new PieChartModel("Apr", 57),
                new PieChartModel("May", 48),
            };
        }
    }
    public partial class PieSample2 : ContentPage
    {
        public PieSample2()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            this.BindingContext = new PieSample2ViewModel();
        }


    }
}
