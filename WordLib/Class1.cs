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

        public bool IsEmpty(string input)
        {
            bool result = String.IsNullOrEmpty(input);
            return result;
        }
    }
}