using System.Collections.Generic;
using Xamarin.Forms;

namespace ChinaWPC
{
    public partial class EducationLevelPage : ContentPage
    {
        public EducationLevelPage()
        {
            InitializeComponent();
            ListView.ItemsSource = new List<string>
            {
                "Bachelor",
                "Master",
                "Doctor"
            };
        }

        public ListView EducationLevels => ListView;
    }
}