namespace MergeStringsAlternatelyProblem
{
    internal class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var word1Length = word1.Length;
            var word2Length = word2.Length;

            var lesserLength = 0;
            var greaterLength = 0;
            var greaterWord = string.Empty;

            if (word1.Length >= word2.Length)
            {
                lesserLength = word2.Length;
                greaterLength = word1.Length;
                greaterWord = word1;
            }
            else if (word1.Length < word2.Length)
            {
                lesserLength = word1.Length;
                greaterLength = word2.Length;
                greaterWord = word2;
            }

            var res = string.Empty;
            var current = word1;

            for (int i = 0; i < lesserLength; i++)
            {

                res += word1[i];
                res += word2[i];

                if (current == word1)
                    current = word2;
                else if (current == word2)
                    current = word1;
            }
            
            for (int j = lesserLength; j < greaterLength; j++)
            {
                res += greaterWord[j];
            }
            
            return res;
        }
    }
}

// MergeAlternately("abc", "pqr");
// merged: a p b q c r

// Input: word1 = "ab", word2 = "pqrs"
// Output: "apbqrs"