using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ChinaWPC
{
    public partial class AgeRangePage : ContentPage
    {
        public AgeRangePage()
        {
            InitializeComponent();
            ListView.ItemsSource = new List<String>
            {
                "18-25",
                "26-45",
                "46-55",
                "56-60",
                "60+"
            };
        }
    
        public ListView AgeRanges { get { return ListView; }}
        
    }
}
