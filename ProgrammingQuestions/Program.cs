namespace ProgrammingQuestions
{
    /*
     Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var digits = "23";
            var result = LetterCombinations(digits);

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
        }

        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();

            /*
            Dictionary<char, char[]> keypad = new Dictionary<char, char[]> {{'2', new char[]{'a', 'b', 'c'}}, 
        {'3', new char[]{'d', 'e', 'f'}}, {'4', new char[] {'g', 'h', 'i'}}, 
        {'5', new char[] {'j', 'k', 'l'}}, {'6', new char[] {'m', 'n', 'o'}}, 
        {'7', new char[] {'p', 'q', 'r', 's'}}, {'8', new char[] {'t', 'u', 'v'}}, 
        {'9', new char[] {'w', 'x', 'y', 'z'}}};
            */
            Dictionary<char, string> digitToChar = new Dictionary<char, string>();
            digitToChar.Add('2', "abc");
            digitToChar.Add('3', "def");
            digitToChar.Add('4', "ghi");
            digitToChar.Add('5', "jkl");
            digitToChar.Add('6', "mno");
            digitToChar.Add('7', "pqrs");
            digitToChar.Add('8', "tuv");
            digitToChar.Add('9', "wxyz");

            void Backtrack(int i, string curStr)
            {
                if (curStr.Length == digits.Length)
                {
                    result.Add(curStr);
                    return;
                }
                foreach (var c in digitToChar[digits[i]])
                {
                    var newStr = curStr + c;
                    Backtrack(i + 1, newStr);
                }
            }
            if (digits.Length > 0)
            {
                Backtrack(0, "");
            }

            return result;
        }
    }
}
