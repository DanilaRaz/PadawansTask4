using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if ( str == null )
            {
                throw new ArgumentNullException();
            }
            char[] separate = { 'a', 'e', 'o', 'u', 'i' }  ;
            int result = 0;
            for (int i=0;i<str.Length;i++)
            {
                for (int j=0;j<separate.Length;j++)
                {
                    if ( str[i] == separate [j])
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
