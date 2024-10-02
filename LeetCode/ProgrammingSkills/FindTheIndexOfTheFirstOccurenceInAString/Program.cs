namespace FindTheIndexOfTheFirstOccurenceInAString
{
    // Given two strings needle and haystack,
    // return the index of the first occurrence of needle
    // in haystack, or -1 if needle is not part of haystack.

    // Constraints:
    // 1 <= haystack.length, needle.length <= 104
    // haystack and needle consist of only lowercase English characters.

    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            //var haystack = "sadbutsad";
            //var needle = "sad";

            //var haystack = "satdbutsadsad";
            //var needle = "sad";

            //var haystack = "leetcode";
            //var needle = "leeto";

            //var haystack = "hello";
            //var needle = "ll";

            //var haystack = "mississippi";
            //var needle = "pi";

            var haystack = "babbbbbabb";
            var needle = "bbab";

            var result = solution.StrStr(haystack, needle);
        }
    }
}
