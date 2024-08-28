namespace FindTheDifferenceProblem
{
    internal class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            int count = 0;

            //bool flag = false;

            //var addedLetterIndex = 0;
            for (int i = 0; i < t.Length; i++) 
            {

                for (int j = 0; j < s.Length; j++)
                { 
                    if (t[i] == s[j]) 
                    {
                        count++;
                        // remove i-th from t
                        t = t.Remove(i, 1);
                        s = s.Remove(j, 1);
                        // remove j-th from s
                        //continue;
                    }
                    //flag = true;
                    //addedLetterIndex = j;
                    //continue;
                }

                if (count == 0 || 
                    (s.Length == 0 && t.Length == 1) ||
                    (s.Length == 1 && t.Length == 0))
                {
                    return t[i];
                }
                count = 0;
            }

            return '\0';
            //if (count == 0)
            //{
            //    return '\n';
            //}

            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = 0; j < t.Length; j++)
            //    {
            //        if (s[i] == t[j])
            //        { 

            //        }
            //    }
            //}

            //var longerString = string.Empty;
            //var shorterString = string.Empty;
            //for (int i = 0; i < longerString.Length; i++)
            //{
            //    if (longerString[i] == shorterString[i])
            //}
        }
    }
}
