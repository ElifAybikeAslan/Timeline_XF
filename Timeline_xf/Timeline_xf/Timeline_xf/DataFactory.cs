using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Timeline_xf.Models;

namespace Timeline_xf
{
    public static class DataFactory
    {
        public static IList<ExerciseClass> Classes { get; private set; }

        private static DateTime TodayAt(int hour, int minute)
        {
            return new DateTime(DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                hour, minute, 0);
        }

        static DataFactory()
        {

            Classes = new ObservableCollection<ExerciseClass>
            {
                new ExerciseClass
                {
                    ClassName = "Yoga",
                    Instructor = "Elif",
                    ClassTime = TodayAt(8,00),
                },
                 new ExerciseClass
                {
                    ClassName = "Yüzme",
                    Instructor = "Aybike",
                    ClassTime = TodayAt(9,30),
                },
                 new ExerciseClass
                {
                    ClassName = "Bisiklet",
                    Instructor = "Fatih",
                    ClassTime = TodayAt(12,00),
                },
                 new ExerciseClass
                {
                    ClassName = "Aerobics",
                    Instructor = "Çağatay",
                    ClassTime = TodayAt(15,30),
                },
                 new ExerciseClass
                {
                    ClassName = "Basketbol",
                    Instructor = "Ayşenur",
                    ClassTime = TodayAt(18,00),
                    IsLast = true
                },
            };
        }
    }
}
