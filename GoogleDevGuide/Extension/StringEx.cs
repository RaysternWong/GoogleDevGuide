﻿using System.Collections.Generic;
using System.Linq;

namespace GoogleDevGuide.Extension
{
    public static class StringEx
    {
        public static string GetLongestSubSequence(this string str, string[] words)
        {
            return str.GetLongestSubSequence(words.ToList());
        }

        public static string GetLongestSubSequence(this string str, List<string> words)
        {
            string result = null;
        
            return result;
        }

        public static bool IsSubSequence(this string str, string word)
        {
            string result = null;
            int j = 0;

            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(word))
                return false;

            for (int i = 0; i < str.Length && j < word.Length; i++)
            {
                if (word[j] == str[i])
                {
                    result += word[j];
                    j++;
                }
            }

            return string.Equals(result, word);
        }
    }
}
