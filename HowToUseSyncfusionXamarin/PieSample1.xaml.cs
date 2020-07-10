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
    public class Model
    {
        public string Month { get; set; }

        public double Target { get; set; }

        public Model(string xValue, double yValue)
        {
            Month = xValue;
            Target = yValue;
        }
    }

    public class Sample2ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public Sample2ViewModel()
        {
            Data = new ObservableCollection<Model>()
            {
                new Model("Jan", 50),
                new Model("Feb", 70),
                new Model("Mar", 1),
                new Model("Apr", 57),
                new Model("May", 48),
            };
        }
    }
    public partial class PieSample1 : ContentPage
    {
        public PieSample1()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            this.BindingContext = new Sample2ViewModel();
        }


    }
}
