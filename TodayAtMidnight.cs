using System;

namespace CSharpDiscovery.Quest02
{
    public class TodayAtMidnight_Exercice
    {
        public static DateTime TodayAtMidnight()
        {
            DateTime endTime = DateTime.Now;
            return endTime.Subtract(endTime.TimeOfDay);
        }
    }
}