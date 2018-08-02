using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChinaWPC
{
    public partial class EducationLevelPage : ContentPage
    {
        public EducationLevelPage()
        {
            InitializeComponent();
            ListView.ItemsSource = new List<String>
            {
                "Bachelor",
                "Master",
                "Doctor"
            };
        }
    
        public ListView EducationLevels { get { return ListView; }}
    }
}
