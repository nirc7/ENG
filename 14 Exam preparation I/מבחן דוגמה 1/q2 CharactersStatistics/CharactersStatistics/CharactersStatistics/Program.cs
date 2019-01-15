using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharactersStatistics
{
   
        /// <summary>
        /// Summary description for Class1.
        /// </summary>
        class CharactersStatisticsMain
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main(string[] args)
            {
                string input = "scubi doo is the best";
                Console.WriteLine(LettersOccurrences(input));
            }

            /// <summary>
            /// Return a string containing how much each letter in the given text is shown.
            /// We assume there are only 22 different letters in the text.
            /// </summary>
            /// <param name="text">The text to count it's letters.</param>
            /// <returns>How much each letter in the given text is shown.</returns>
            static string LettersOccurrences(string text)
            {
                // init.
                // we assume the number of letters is no greater than 22.
                int[] numberOfLetter = new int[22];
                string[] letters = new string[22];
                int position = 0;
                string result = "";

                // looping over the text and counting how much each letter is showed.
                for (int i = 0; i < text.Length; i++)
                {
                    string letter = text.Substring(i, 1);
                    bool letterFound = false;
                    // if the letter is already in the array than increment 
                    // the number it is showed.
                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (letter == letters[j])
                        {
                            numberOfLetter[j]++;
                            letterFound = true;
                        }
                    }
                    // if the letter was not in the array than we need to add it.
                    if (!letterFound)
                    {
                        letters[position] = letter;
                        numberOfLetter[position]++;
                        position++;
                    }
                }
                // constructing the result string.
                for (int i = 0; i < position; i++)
                {
                    if (i != 0)
                    {
                        result = result + ", ";
                    }
                    result = result + letters[i] + " - " + numberOfLetter[i];
                }
                return result;
            }
        }
}
