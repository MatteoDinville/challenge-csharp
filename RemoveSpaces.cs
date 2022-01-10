namespace CSharpDiscovery.Quest01
{
    public class RemoveSpaces_Exercice
    {
        public static string RemoveSpaces(string str)
        {
            if (str == null)
            {
                return "0";
            }
            return str.Trim();
        }
    }
}