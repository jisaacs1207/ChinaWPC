using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChinaWPC
{
    public partial class AnnualWorkPage : ContentPage
    {
        public AnnualWorkPage()
        {
            InitializeComponent();
            ListView.ItemsSource = new List<String>
            {
                "<3m",
                "3m-6m",
                "6m-9m",
                ">9m"
            };
        }
    
        public ListView AnnualWorkRanges { get { return ListView; }}
    }
}
