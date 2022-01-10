namespace CSharpDiscovery.Quest01
{
    public class DoubleArrayForEvenInteger_Exercice
    {
        public static int[] DoubleArrayForEvenInteger(int[] inputTab)
        {
            int num;
            // parcourir ton array
            for (int i = 0; i < inputTab.Length; i++)
            {
                // check si c pair ou impair
               
                if ( inputTab[i] % 2 != 0)
                {
                    num = inputTab[i] * 2;
                }
                else
                {
                    num = inputTab[i];
                }
                inputTab[i] = num;

            }
            // return le tab contenant les résultats
            return inputTab;
        }
    }
}