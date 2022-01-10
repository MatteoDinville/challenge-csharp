using System;

namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            if (Array.IndexOf(tab, value) == -1)   
            {
                return true;
            }else 
            {
                return false; 
            }
            if (tab == null)
            {
                return false;
            }
        }
    }
}