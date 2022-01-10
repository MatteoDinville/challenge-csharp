namespace CSharpDiscovery.Quest02
{
    public class AreEquals_Exercice
    {
        public static bool AreEquals(int[] tab1, int[] tab2)
        {
            bool result = false;
          if (tab1.Length == tab2.Length)
            {
                for (int i = 0; i < tab1.Length; i++)
                {
                    if (tab1[i] == tab2[i])
                    {
                        result = true;
                    }else
                    {
                        result = false;
                    }
                }
            }
            return result;
        }
    }
}