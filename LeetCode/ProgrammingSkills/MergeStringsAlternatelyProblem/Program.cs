namespace MergeStringsAlternatelyProblem
{
    // You are given two strings word1 and word2.
    // Merge the strings by adding letters in alternating order,
    // starting with word1.If a string is longer than the other,
    // append the additional letters onto the end of the merged string.

    // Return the merged string.

    // Constraints:
    // 1 <= word1.length, word2.length <= 100
    // word1 and word2 consist of lowercase English letters.

    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            // solution.MergeAlternately("abc", "pqr");
            solution.MergeAlternately("ab", "pqrs");

            // merged: a p b q c r
        }
    }
}