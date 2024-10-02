namespace ValidAnagram
{
    // Given two strings s and t, return true if t is an 
    // anagram of s, and false otherwise.

    // An Anagram is a word or phrase formed by rearranging the letters 
    // of a different word or phrase, using all the original letters exactly once.

    // Constraints:
    // 1 <= s.length, t.length <= 5 * 104
    // s and t consist of lowercase English letters.

    // Follow up: What if the inputs contain Unicode
    // characters? How would you adapt your solution
    // to such a case?

    internal class Program
    {

        static void Main(string[] args)
        {
            var solution = new Solution();

            string s = string.Empty;
            string t = string.Empty;
            // s = "anagram"; t = "nagaram";
            // s = "rat"; t = "car";
            // s = "ac"; t = "bb";
            // s = "aa"; t = "a";
            s = "fe"; t = "ja";
            //s = "abd"; t = "eaa";
            //s = "presidentobama"; t = "abaptismredone";
           
            var result = solution.IsAnagram(s, t);
        }
    }
}
