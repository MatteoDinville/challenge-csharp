using System;

namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
           if (tab == null)
            {
                return null; 
            }
            int lastIndex = Array.LastIndexOf(tab, a);
            return lastIndex > 0 ? lastIndex : null;
        }
    }
}