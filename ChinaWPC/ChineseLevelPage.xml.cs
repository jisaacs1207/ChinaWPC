using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChinaWPC
{
    public partial class ChineseLevelPage : ContentPage
    {
        public ChineseLevelPage()
        {
            InitializeComponent();
            ListView.ItemsSource = new List<String>
            {
                "None",
                "HSK1",
                "HSK2",
                "HSK3",
                "HSK4",
                "HSK5",
                "Bachelor",
                "Native"
            };
        }
    
        public ListView ChineseLevels { get { return ListView; }}
    }
}
