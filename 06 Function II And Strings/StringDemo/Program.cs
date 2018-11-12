using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "a v i cohen";
            Console.WriteLine(name.Length);
            string sub = name.Substring(6);
            Console.WriteLine(sub);
            string sub2 = name.Substring(2, 5);
            Console.WriteLine(sub2);
            char c = name[2];
            //name[2] = 'V';
            name = ChangeToUpper(name, 7);
            Console.WriteLine(name);

            Console.WriteLine(CountLetter("1234434257", '8'));
            Console.WriteLine(FindSubSequence("123345789", "123"));
            Console.WriteLine(FindSubSequence2("123345789", "344"));
            Console.WriteLine(FindSubSequence3("123345789", "344"));
            Console.WriteLine(name.Contains("cO"));


            Console.WriteLine(Reverse("hello"));
            Console.WriteLine(Reverse2("hello"));
            Console.WriteLine(IsPalimdrome("rotor"));
            Console.WriteLine(IsPalimdrome("rotor2"));
            Console.WriteLine(IsPalimdrome2("rotor"));
            Console.WriteLine(IsPalimdrome2("rotor2"));
        }

        static bool IsPalimdrome2(string word)
        {
            
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length-i-1])
                {
                    return false;
                }
            }
            return true;
        }

            static bool IsPalimdrome(string word)
        {
            return Reverse(word) == word;
        }

        static string Reverse(string word)
        {
            string str = "";
            for (int i = 0; i < word.Length; i++)
            {
                str = word[i] + str;
            }
            return str;
        }

        static string Reverse2(string word)
        {
            string str = "";
            for (int i = word.Length - 1; 0 <= i; i--)
            {
                str += word[i];//olleh
            }
            return str;
        }

        static bool FindSubSequence3(string sequence, string sub)
        {
            //opt1
            return sequence.IndexOf(sub) != -1;

            //opt2 - not recommend
            //if (sequence.IndexOf(sub) == -1)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}            
        }

        static bool FindSubSequence2(string sequence, string sub)
        {
            for (int i = 0; i <= sequence.Length - sub.Length; i++)
            {
                if (sequence.Substring(i, sub.Length) == sub)
                {
                    return true;
                }
            }
            return false;
        }

        static bool FindSubSequence(string sequence, string sub)
        {
            for (int i = 0; i <= sequence.Length - sub.Length; i++)
            {
                int j = 0;
                for (; j < sub.Length; j++)
                {
                    if (sequence[i + j] != sub[j])
                    {
                        break;
                    }
                }
                if (j == sub.Length)
                {
                    return true;
                }
            }
            return false;
        }

        static int CountLetter(string sentence, char letter)
        {
            int counter = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == letter)
                {
                    counter++;
                }
            }
            return counter;
        }

        static string ChangeToUpper(string name, int index)
        {
            name = name.Substring(0, index) +
                    name[index].ToString().ToUpper()/*converted to string in order to use the ToUpper() function*/ +
                    name.Substring(index + 1);
            return name;
        }
    }
}
