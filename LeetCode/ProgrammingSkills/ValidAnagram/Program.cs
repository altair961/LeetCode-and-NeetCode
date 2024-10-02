namespace ValidAnagram
{
    internal class Program
    {
        // Given two strings s and t, return true if t is an 
        // anagram of s, and false otherwise.

        // An Anagram is a word or phrase formed by rearranging the letters 
        // of a different word or phrase, using all the original letters exactly once.

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
            /*

            char x;
            
            int[] index = new int[256];
            for (int i = 0; i < 256; i++)
            {
                index[i] = -1;
            }

            int[] count = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                x = s[i];
                ++count[x];

                if (count[x] == 1)
                    index[x] = i;

                if (count[x] > 1)
                    index[x] = -1;
            }
            
            int[] count2 = new int[256];
            int[] index2 = new int[256];
            for (int i = 0; i < 256; i++)
            {
                index2[i] = -1;
            }

            for (int i = 0; i < t.Length; i++)
            {
                x = t[i];
                ++count2[x];

                if (count2[x] == 1)
                    index2[x] = i;

                if (count2[x] > 1)
                    index2[x] = -1;
            }

            int sum = 0;
            Console.WriteLine("s: ");
            for (int i = 0; i < 256; i++)
                if (index[i] != -1) 
                {
                    Console.Write(s[index[i]]);
                    sum += s[index[i]]; 
                }

            Console.WriteLine("\n\nt : ");

            int sum2 = 0;
            for (int i = 0; i < 256; i++)
                if (index2[i] != -1) 
                {
                    Console.Write(t[index2[i]]);
                    sum2 += t[index2[i]];
                }

            Console.WriteLine("\n\nsum: " + sum);
            Console.WriteLine("sum2: " + sum2);
            */
            var result = solution.IsAnagram(s, t);
        }
    }
}
