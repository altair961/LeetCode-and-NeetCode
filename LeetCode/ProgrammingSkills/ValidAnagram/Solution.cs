namespace ValidAnagram
{
    internal class Solution
    {
        public bool IsAnagram(string s, string t)
        {
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

            Console.WriteLine("s: ");
            int sameCharCountCheck1 = 0;
            for (int i = 0; i < 256; i++)
                if (index[i] != -1 && index2[i] != -1)
                {
                    Console.Write(s[index[i]]);

                    if (s[index[i]] == t[index2[i]])
                        sameCharCountCheck1++;
                }

            int sameCharCountCheck2 = 0;
            for (int i = 0; i < 256; i++)
                if (index[i] != -1 && index2[i] != -1)
                {
                    Console.Write(s[index[i]]);

                    if (s[index[i]] == t[index2[i]])
                        sameCharCountCheck2++;
                }

            if (sameCharCountCheck1 == sameCharCountCheck2)
                return true;

            return  false;
            /*
            if (s.Length != t.Length)
                return false;

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
                count[x] = 0;
            }

            int valuesSum = 0;
            for (int i = 0; i < 256; i++)
                if (index[i] != -1)
                {
                    valuesSum += s[index[i]];
                    index[i] = -1;
                }

            for (int i = 0; i < t.Length; i++)
            {
                x = t[i];
                ++count[x];

                if (count[x] == 1)
                    index[x] = i;

                if (count[x] > 1)
                    index[x] = -1;
                count[x] = 0;
            }

            for (int i = 0; i < 256; i++)
                if (index[i] != -1)
                {
                    valuesSum -= t[index[i]];
                    index[i] = -1;
                }

            if (valuesSum == 0)
                return true;
            
            return false;
            */
        }
    }
}