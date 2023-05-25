namespace WordLib
{
    public class Worder
    {
        public string IsPalindrome(string input)
        {
            char[] stringArray = input.ToCharArray();
            Array.Reverse(stringArray);
            string result = new string(stringArray);
            return result;
        }
    }
}