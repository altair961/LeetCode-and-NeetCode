namespace FindTheDifferenceProblem
{
    internal class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            var sSum = 0;
            for (int i = 0; i < s.Length; i++)
                sSum += s[i];

            var tSum = 0;
            for (int j = 0; j < t.Length; j++)
                tSum += t[j];

            var c = (char)(tSum - sSum);

            return c;
        }
    }
}