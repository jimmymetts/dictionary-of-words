using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         Create a dictionary with key value pairs to
         represent words (key) and its definition (value)
     */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();
            {
                // Add several more words and their definitions
                wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
                wordsAndDefinitions.Add("foolk", "a musician from Slovakia. Weird jazz, electronica and hip-hop#");
                wordsAndDefinitions.Add("Jazz Finger", "to show off in an unecessary fashion");
            };
            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            // Console.WriteLine(wordsAndDefinitions["Awesome"]);
            // Console.WriteLine(wordsAndDefinitions["foolk"]);
            // Console.WriteLine(wordsAndDefinitions["Jazz Finger"]);

            /*Below, loop over the wordsAndDefinitions dictionary to get the following output:*/

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }
    }
}
