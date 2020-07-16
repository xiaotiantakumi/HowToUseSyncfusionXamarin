using System.Drawing;

namespace HowToUseSyncfusionXamarin
{
    public class PieChartModel
    {
        public string Month { get; set; }

        public double Target { get; set; }
        

        public PieChartModel(string xValue, double yValue)
        {
            Month = xValue;
            Target = yValue;
        }
    }
}