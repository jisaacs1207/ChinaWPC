using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;

namespace ChinaWPC
{
    public partial class MainPage
    {
        
        
        public static int AgePoints = 10;
        public static int EducationPoints = 10;
        public static int UniversityPoints = 0;
        public static int IpOwnerPoints = 0;
        
        public static int SalaryPoints = 0;
        public static int WorkMonthsPoints = 0;
        public static int ExperiencePoints = 0;
        public static int F500Points = 0;
        
        public static int ChinesePoints = 0;
        public static int FiveYearsPoints = 0;
        public static int HighNeedPoints = 0;
        public static int ProvincialPoints = 0;

        public static Dictionary<string,int> AgeStrings = new Dictionary<string, int>();
        public static Dictionary<string,int> EducationStrings = new Dictionary<string, int>();
        public static Dictionary<string,int> SalaryStrings = new Dictionary<string, int>();
        public static Dictionary<string,int> MonthsStrings = new Dictionary<string, int>();
        public static Dictionary<string,int> ExperienceStrings = new Dictionary<string, int>();
        public static Dictionary<string,int> ChineseStrings = new Dictionary<string, int>();

        
        
        public MainPage()
        {
            InitializeComponent();
            Utility.InitializeDictionary();
            PointsLabel.Text=Utility.CallTotalPoints().ToString();
            GradeLabel.Text = Utility.RetrieveLetterGrade();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            var page = new AnnualSalaryPage();
            page.AnnualSalaries.ItemSelected += (imageSource, args) =>
            {
                AnnualSalaryRange.Text = args.SelectedItem.ToString();
                foreach (var entry in SalaryStrings)
                {
                    if (!entry.Key.Equals(args.SelectedItem.ToString())) continue;
                    SalaryPoints = entry.Value;
                    PointsLabel.Text=Utility.CallTotalPoints().ToString();
                    GradeLabel.Text = Utility.RetrieveLetterGrade();
                }
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }

        void Handle_Tapped_1(object sender, System.EventArgs e)
        {
            var page = new AgeRangePage();
            
            page.AgeRanges.ItemSelected += (imageSource, args) =>
            {
                AgeRange.Text = args.SelectedItem.ToString();
                foreach (var entry in AgeStrings)
                {
                    if (!entry.Key.Equals(args.SelectedItem.ToString())) continue;
                    AgePoints = entry.Value;
                    PointsLabel.Text=Utility.CallTotalPoints().ToString();
                    GradeLabel.Text = Utility.RetrieveLetterGrade();
                }
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }

        void Handle_Tapped_2(object sender, System.EventArgs e)
        {
            var page = new EducationLevelPage();
            page.EducationLevels.ItemSelected += (imageSource, args) =>
            {
                EducationLevel.Text = args.SelectedItem.ToString();
                foreach (var entry in EducationStrings)
                {
                    if (!entry.Key.Equals(args.SelectedItem.ToString())) continue;
                    EducationPoints = entry.Value;
                    PointsLabel.Text=Utility.CallTotalPoints().ToString();
                    GradeLabel.Text = Utility.RetrieveLetterGrade();
                }
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }

        void Handle_Tapped_3(object sender, System.EventArgs e)
        {
            var page = new AnnualWorkPage();
            page.AnnualWorkRanges.ItemSelected += (imageSource, args) =>
            {
                AnnualWork.Text = args.SelectedItem.ToString();
                foreach (var entry in MonthsStrings)
                {
                    if (!entry.Key.Equals(args.SelectedItem.ToString())) continue;
                    WorkMonthsPoints = entry.Value;
                    PointsLabel.Text=Utility.CallTotalPoints().ToString();
                    GradeLabel.Text = Utility.RetrieveLetterGrade();
                }
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }

        void Handle_Tapped_4(object sender, System.EventArgs e)
        {
            var page = new YearsExperiencePage();
            page.YearsExperience.ItemSelected += (imageSource, args) =>
            {
                YearsOfExperience.Text = args.SelectedItem.ToString();
                foreach (var entry in ExperienceStrings)
                {
                    if (!entry.Key.Equals(args.SelectedItem.ToString())) continue;
                    ExperiencePoints = entry.Value;
                    PointsLabel.Text=Utility.CallTotalPoints().ToString();
                    GradeLabel.Text = Utility.RetrieveLetterGrade();
                }
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }

        void Handle_Tapped_5(object sender, System.EventArgs e)
        {
            var page = new ChineseLevelPage();
            page.ChineseLevels.ItemSelected += (imageSource, args) =>
            {
                ChineseLevel.Text = args.SelectedItem.ToString();
                foreach (var entry in ChineseStrings)
                {
                    if (!entry.Key.Equals(args.SelectedItem.ToString())) continue;
                    ChinesePoints = entry.Value;
                    PointsLabel.Text=Utility.CallTotalPoints().ToString();
                    GradeLabel.Text = Utility.RetrieveLetterGrade();
                }
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }

        private void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
           
            if (e.Value)
            {
                UniversityPoints = 5;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
            else
            {
                UniversityPoints = 0;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
        }

        private void Switch_OnToggled1(object sender, ToggledEventArgs e)
        {
           
            if (e.Value)
            {
                IpOwnerPoints = 5;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
            else
            {
                IpOwnerPoints = 0;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
        }

        private void Switch_OnToggled2(object sender, ToggledEventArgs e)
        {
           
            if (e.Value)
            {
                F500Points = 5;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
            else
            {
                F500Points = 0;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
        }

        private void Switch_OnToggled3(object sender, ToggledEventArgs e)
        {
           
            if (e.Value)
            {
                FiveYearsPoints = 5;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
            else
            {
                FiveYearsPoints = 0;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
        }

        private void Switch_OnToggled4(object sender, ToggledEventArgs e)
        {
           
            if (e.Value)
            {
                HighNeedPoints = 5;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
            else
            {
                HighNeedPoints = 0;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
        }

        private void Switch_OnToggled5(object sender, ToggledEventArgs e)
        {
           
            if (e.Value)
            {
                ProvincialPoints = 5;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
            else
            {
                ProvincialPoints = 0;
                PointsLabel.Text=Utility.CallTotalPoints().ToString();
                GradeLabel.Text = Utility.RetrieveLetterGrade();
            }
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {   
            DisplayAlert("Top 100 University Graduate",
                "Did you attend one of the top 100 world Universities?\n\nIt's unclear what chart the government uses" +
                " to check. \n\nAs any chart changes often, it may be best to look on the internet for this.",
                "OK");
        }
        private void Button_OnClicked1(object sender, EventArgs e)
        {   
            DisplayAlert("Ownership of Intellectual Property",
                "Do you own any IP in any form?\n\nThis could include trade secrets, trademarks," +
                " copyrights, or patents. \n\nIf you've officially registered anything, take these points.",
                "OK");
        }
        private void Button_OnClicked2(object sender, EventArgs e)
        {   
            DisplayAlert("Fortune 500 Experience",
                "Have you ever been employed in a Fortune 500 Enterprise?\n\nSurprisingly, many people have and" +
                " don't know it.\n\nCheck the current F500 list for any of your previous employers.",
                "OK");
        }
        private void Button_OnClicked3(object sender, EventArgs e)
        {   
            DisplayAlert("Continuous Employment",
                "Have you worked continuously (without a break) in China for 5 years or more?" +
                "\n\nIf you claim these points, be prepared to provide documentation to prove it.",
                "OK");
        }
        private void Button_OnClicked4(object sender, EventArgs e)
        {   
            DisplayAlert("Employment in a High Need Region",
                "Do you work in the West, North-East, old industial, or other poor areas of China?" +
                "\n\nMany employers don't know if their region qualifies, and forgo trying to claim this section." +
                "\n\nCheck directly with your local Public Security Bureau to see if you can claim these points.",
                "OK");
        }
        private void Button_OnClicked5(object sender, EventArgs e)
        {   
            DisplayAlert("Special Provincial Requirements",
                "Do you meet some kind of special need in your province?" +
                "\n\nIn order to make the system more flexible, this criteria was added to give officials the ability" +
                " to manage points in a more pragmatic way." +
                "\n\nThe local governmental websites have the changing criteria for each province. It wouldn't hurt to look.",
                "OK");
        }
    }
}
