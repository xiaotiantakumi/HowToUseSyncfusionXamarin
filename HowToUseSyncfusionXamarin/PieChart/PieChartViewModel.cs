using System.Collections.ObjectModel;

namespace HowToUseSyncfusionXamarin
{
    public class PieChartViewModel
    {
        public ObservableCollection<PieChartModel> Data { get; set; }

        public PieChartViewModel()
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
}