using System.Collections.Generic;
using Xamarin.Forms;

namespace ChinaWPC
{
    public partial class AnnualSalaryPage
    {
        public AnnualSalaryPage()
        {
            InitializeComponent();
            ListView.ItemsSource = new List<string>
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

        public ListView AnnualSalaries => ListView;
    }
}