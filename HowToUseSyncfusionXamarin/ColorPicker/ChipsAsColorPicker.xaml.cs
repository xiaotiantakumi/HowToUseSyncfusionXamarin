using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HowToUseSyncfusionXamarin.ColorPicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChipsAsColorPicker : ContentPage, INotifyPropertyChanged
    {
        #region Members

        private ObservableCollection<Color> colors;
        private object selectedItem;
        private Color selectedColor;
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public ChipsAsColorPicker()
        {
            InitializeComponent();
            Colors = new ObservableCollection<Color>();
            foreach (var color in typeof(Color).GetFields())
            {
                Colors.Add((Color)typeof(Color).GetField(color.Name).GetValue(this));
            }
            this.BindingContext = this;
        }

        #region Properties

        public ObservableCollection<Color> Colors
        {
            get
            {
                return colors;
            }
            set
            {
                colors = value;
                OnPropertyChanged("Colors");
            }
        }

        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public Color SelectedColor
        {
            get
            {
                return selectedColor;
            }
            set
            {
                selectedColor = value;
                OnPropertyChanged("SelectedColor");
            }
        }

        #endregion

        #region On Property Changed

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        #endregion
    }
}