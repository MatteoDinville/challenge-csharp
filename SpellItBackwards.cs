namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
            string result = "";
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            for (int i = str.Length - 1 ; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }
}