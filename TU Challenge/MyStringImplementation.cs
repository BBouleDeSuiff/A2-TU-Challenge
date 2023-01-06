using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null)
                return (true);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                    return (false);
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            if (IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b))
                throw new ArgumentException();
            string c = "";
            for (int i = 0; i < (a.Length > b.Length ? a.Length : b.Length); i++)
            {
                if(i < a.Length)
                    c += a[i];
                if (i < b.Length)
                    c += b[i];
            }
            return c;
        }

        public static string Reverse(string a)
        {
            string b = "";
            for (int i = a.Length-1; i >=0; i--)
            {
                b += a[i];
            }
            return b;
        }

        public static string ToCesarCode(string input, int offset)
        {
            string output = "";

            foreach (int letter in input)
            {
                if (IsNullEmptyOrWhiteSpace(((char)letter).ToString()))
                    output += " ";
                else if(letter + offset >= 97 && letter + offset <= 122)
                    output += (char)(letter + offset);
                else
                    output += (char)(97 + ( offset- (122 - letter))-1);
            }
            return output;
        }

        public static string ToLowerCase(string a)
        {
            string s = "";

            foreach (int i in a)
            {
                if (i >= 65 && i <= 90) 
                    s += (char)(i + 32);
                else if (i >= 192 && i <= 223)
                    s += (char)(i + 32);
                else 
                    s += (char)i;
            }
             return s;
        }

        public static string BazardString(string input)
        {
            string output = "";
            for (int j = 0; j <= 1; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == j)
                        output += input[i];
                }
            }
            return output;
        }

        public static string UnBazardString(string input)
        {
            string output = "";
            int midValue = (input.Length + 1) / 2;
            for (int i = 0; i <= midValue - 1; i++)
            {
                output = output + input[i] + input[i + midValue];
            }
            return output;

        }

        public static string Voyelles(string a)
        {
            string voyelles = "aeiouy";
            string foundVoyelles = "";
            foreach (char letter in a)
            {
                foreach (char voyelle in voyelles)
                {
                    if ((letter == voyelle || ToLowerCase(letter.ToString())[0] == voyelle) && !foundVoyelles.Contains(voyelle))
                        foundVoyelles += voyelle;
                }
            }
            return foundVoyelles;
        }
    }
}
