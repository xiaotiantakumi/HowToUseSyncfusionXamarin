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
        public ObservableCollection<Model> Data { get; set; }

        public PieSample2ViewModel()
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
