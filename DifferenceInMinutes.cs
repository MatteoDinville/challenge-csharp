﻿using System;

namespace CSharpDiscovery.Quest02
{
    public class DifferenceInMinutes_Exercice
    {
        public static double DifferenceInMinutes(DateTime start, DateTime end)
        {

            var result = (int)end.Subtract(start).TotalMinutes;
            return result;
        }
    }
}