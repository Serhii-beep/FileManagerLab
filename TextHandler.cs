using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FileManagerLab
{
    class TextHandler
    {
        public static string ChangeWordsSequence(string text, string whatChange, string toWhatChange)
        {
            return text.Replace(whatChange, toWhatChange);
        }

        private static int ComputeLevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];
            if (n == 0)
            {
                return m;
            }
            if (m == 0)
            {
                return n;
            }
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                    d[i, j] = Math.Min(
                    Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                    d[i - 1, j - 1] + cost);
                }
            }
            return d[n, m];
        }
        public static string FindFuzzyWords(List<string> allWords, string wordToFind)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var word in allWords)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, ComputeLevenshteinDistance(word, wordToFind));
                }
            }
            int min = words.Min(x => x.Value);
            StringBuilder result = new StringBuilder();
            foreach (var word in words)
            {
                if (word.Value == min)
                {
                    result.Append(word.Key + "\n");
                }
            }
            return result.ToString();
        }
    }
}
