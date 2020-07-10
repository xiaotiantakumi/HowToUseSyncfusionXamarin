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
    public class Person
    {
        public string Name { get; set; }

        public double Height { get; set; }
    }
    public class ViewModel
    {
        public List<Person> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Person>()
            {
                new Person { Name = "David", Height = 180 },
                new Person { Name = "Michael", Height = 170 },
                new Person { Name = "Steve", Height = 160 },
                new Person { Name = "Joel", Height = 182 }
            };
        }
    }
    public partial class Sample1 : ContentPage
    {
        public Sample1()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            this.BindingContext = new ViewModel();
        }


    }
}
