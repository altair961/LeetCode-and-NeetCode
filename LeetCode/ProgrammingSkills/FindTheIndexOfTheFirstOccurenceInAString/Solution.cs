namespace FindTheIndexOfTheFirstOccurenceInAString
{
    internal class Solution
    {
        public int StrStr(string haystack, string needle) 
        {
            var haystackCurrentPieceSum = 0;
            var needleSum = 0;
            for (var j = 0; j < needle.Length; j++)
                needleSum += needle[j];

            for (var i = 0; i < haystack.Length; i++)
            {
                haystackCurrentPieceSum += haystack[i];

                if (i >= needle.Length)
                {
                    haystackCurrentPieceSum -= haystack[i - needle.Length];
                }

                if (haystackCurrentPieceSum == needleSum)
                {
                    var haystackCurrentPieceBeginningIndex = i - needle.Length + 1;
                    var needleIndex = 0;
                    for (int k = haystackCurrentPieceBeginningIndex; needleIndex < needle.Length; k++, needleIndex++)
                    {
                        if (haystack[k] != needle[needleIndex])
                        {
                            break;
                        }

                        if (needleIndex == needle.Length - 1)
                        {
                            return k - (needle.Length - 1); 
                        }
                    }
                }
            }

            return -1;
        }
    }
}
