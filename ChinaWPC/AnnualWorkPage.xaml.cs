using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChinaWPC
{
    public partial class AnnualSalaryPage : ContentPage
    {
        public AnnualSalaryPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<String>
            {
                "<¥50K",
                "¥50k-¥70k",
                "¥70k-¥150k",
                "¥150k-¥250k",
                "¥250k-¥350k",
                "¥350k-¥450k",
                ">¥450k"
            };
        }
    
        public ListView AnnualSalaries { get { return listView; }}
    }
}
