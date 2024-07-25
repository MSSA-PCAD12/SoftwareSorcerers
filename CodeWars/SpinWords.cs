using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SpinWords
    {
        public static string SpinWordsMain(string sentence)
        {
            StringBuilder sb = new StringBuilder();
            List<string> words = Extension.Split(sentence);

            foreach (string word in words)
            {
                if (word.Length >= 5)
                {
                    string revWord = Extension.ReverseWord(word);
                    sb.Append(revWord);
                }
                else
                {
                    sb.Append(word);
                }
                sb.Append(' ');
            }
            return Extension.Join(sb);
        }
    }
        public static class Extension
    {
        public static List<string> Split(this string sentence)
        {
            StringBuilder sb = new StringBuilder();
            List<string> strList = new List<string>();
            foreach (char letter in sentence)
            {
                if (letter != ' ')
                {
                    sb.Append(letter);
                }
                else
                {
                    strList.Add(sb.ToString());
                    sb.Clear();
                }
            }
            strList.Add(sb.ToString());
            return strList;
        }
        public static string Join(StringBuilder sb)
        {
            string str = "";
            for (int i = 0; i < sb.Length; i++)
            {
                if (i != sb.Length - 1)
                {
                    str += sb[i];
                }
                if (i == sb.Length - 1 && sb[i] != ' ')
                {
                    str += sb[i];
                }
            }
            return str;
        }
        //   public static string Join(StringBuilder sb) { // needs to be a char array
        //     var phrase = sb.Aggregate((partialPhrase, word) => $"{partialPhrase} {word}");
        //     return phrase;
        //     }
        public static string ReverseWord(string word)
        {
            StringBuilder sb = new StringBuilder();
            char[] charArray = word.ToCharArray();
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                sb.Append(charArray[i]);
            }
            //         return sb.ToString();
            return Join(sb);
        }
    }
}

