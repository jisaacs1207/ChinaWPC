using System.Collections.Generic;
using Xamarin.Forms;

namespace ChinaWPC
{
    public partial class YearsExperiencePage : ContentPage
    {
        public YearsExperiencePage()
        {
            InitializeComponent();
            ListView.ItemsSource = new List<string>
            {
                "<2y",
                "2y",
                "3y",
                "4y",
                "5y",
                "6y",
                "7y",
                "8y",
                "9y",
                "10y",
                "11y",
                "12y",
                "13y",
                "14y",
                "15y",
                "16y",
                "17y",
                ">17y"
            };
        }

        public ListView YearsExperience => ListView;
    }
}