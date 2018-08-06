using System.Collections.Generic;
using Xamarin.Forms;

namespace ChinaWPC
{
    public partial class ChineseLevelPage : ContentPage
    {
        public ChineseLevelPage()
        {
            InitializeComponent();
            ListView.ItemsSource = new List<string>
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

        public ListView ChineseLevels => ListView;
    }
}