namespace FindTheIndexOfTheFirstOccurenceInAString
{
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
