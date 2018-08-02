using System;

namespace ChinaWPC
{
    public static class Utility
    {
        public static int CallTotalPoints()
        {
            var totalPoints = 0;

            totalPoints = MainPage.AgePoints + MainPage.EducationPoints +
                                 MainPage.UniversityPoints + MainPage.IpOwnerPoints +
                                 MainPage.SalaryPoints + MainPage.WorkMonthsPoints +
                                 MainPage.ExperiencePoints + MainPage.F500Points +
                                 MainPage.ChinesePoints + MainPage.FiveYearsPoints +
                                 MainPage.HighNeedPoints + MainPage.ProvincialPoints;

            return totalPoints;
        }

        public static string RetrieveLetterGrade()
        {
            var points = CallTotalPoints();
            var grade = "C";
            if(points<60)
            {
                grade = "C";
            }
            else if (points < 85)
            {
                grade = "B";
            }
            else grade = "A";

            return grade;
        }

        public static void InitializeDictionary()
        {
            MainPage.AgeStrings.Add("18-25", 10);
            MainPage.AgeStrings.Add("26-45", 15);
            MainPage.AgeStrings.Add("46-55", 10);
            MainPage.AgeStrings.Add("56-60", 5);
            MainPage.AgeStrings.Add("60+", 0);

            MainPage.EducationStrings.Add("Bachelor", 10);
            MainPage.EducationStrings.Add("Master", 15);
            MainPage.EducationStrings.Add("Doctor", 20);

            MainPage.SalaryStrings.Add("<¥50K", 0);
            MainPage.SalaryStrings.Add("¥50k-¥70k", 5);
            MainPage.SalaryStrings.Add("¥70k-¥150k", 8);
            MainPage.SalaryStrings.Add("¥150k-¥250k", 11);
            MainPage.SalaryStrings.Add("¥250k-¥350k", 14);
            MainPage.SalaryStrings.Add("¥350k-¥450k", 17);
            MainPage.SalaryStrings.Add(">¥450k", 20);

            MainPage.MonthsStrings.Add("<3m", 0);
            MainPage.MonthsStrings.Add("3m-6m", 5);
            MainPage.MonthsStrings.Add("6m-9m", 10);
            MainPage.MonthsStrings.Add(">9m", 15);

            MainPage.ExperienceStrings.Add("<2y", 0);
            MainPage.ExperienceStrings.Add("2y", 5);
            MainPage.ExperienceStrings.Add("3y", 6);
            MainPage.ExperienceStrings.Add("4y", 7);
            MainPage.ExperienceStrings.Add("5y", 8);
            MainPage.ExperienceStrings.Add("6y", 9);
            MainPage.ExperienceStrings.Add("7y", 10);
            MainPage.ExperienceStrings.Add("8y", 11);
            MainPage.ExperienceStrings.Add("9y", 12);
            MainPage.ExperienceStrings.Add("10y", 13);
            MainPage.ExperienceStrings.Add("11y", 14);
            MainPage.ExperienceStrings.Add("12y", 15);
            MainPage.ExperienceStrings.Add("13y", 16);
            MainPage.ExperienceStrings.Add("14y", 17);
            MainPage.ExperienceStrings.Add("15y", 18);
            MainPage.ExperienceStrings.Add("16y", 19);
            MainPage.ExperienceStrings.Add("17y", 20);
            MainPage.ExperienceStrings.Add(">17y", 20);

            MainPage.ChineseStrings.Add("None", 0);
            MainPage.ChineseStrings.Add("HSK1", 1);
            MainPage.ChineseStrings.Add("HSK2", 2);
            MainPage.ChineseStrings.Add("HSK3", 3);
            MainPage.ChineseStrings.Add("HSK4", 4);
            MainPage.ChineseStrings.Add("HSK5", 5);
            MainPage.ChineseStrings.Add("Bachelor", 5);
            MainPage.ChineseStrings.Add("Native", 5);
        }

      
    }
}