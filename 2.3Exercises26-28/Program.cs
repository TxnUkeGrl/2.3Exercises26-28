using System;

namespace _2._3Exercises26_28
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Again = true;

            while (Again)
            {
                Console.WriteLine("Enter some text & we'll count the vowels!");
                string Input = Console.ReadLine().ToLower();
                Console.WriteLine($"Your text has {VowelsCountOutput(Input)} vowels.");
                Console.WriteLine("Want to go again? Y/N");
                string loop = Console.ReadLine().ToLower();
                if (loop == "y")
                {
                    Again = true;
                }
                else
                {
                    Again = false;
                }

            }

            Again = true;

            while (Again)
            {
                Console.WriteLine("Enter some other text & we'll count the consonants!");
                string Input = Console.ReadLine().ToLower();
                Console.WriteLine($"Your text has {ConsonantsCountOutput(Input)} consonants.");
                Console.WriteLine("Want to go again? Y/N");
                string loop = Console.ReadLine().ToLower();
                if (loop == "y")
                {
                    Again = true;
                }
                else
                {
                    Again = false;
                }

            }

            Again = true;

            while (Again)
            {
                Console.WriteLine("Lastly, let's remove all of the vowels in the next text!");
                string Input = Console.ReadLine();
                Console.WriteLine($"\"{FindAndRemoveVowels(Input)}\" is your text without vowels.");
                Console.WriteLine("Want to go again? Y/N");
                string loop = Console.ReadLine().ToLower();

                if (loop == "y")
                {
                    Again = true;
                }
                else
                {
                    Again = false;
                    Console.WriteLine("All done, thanks for testing!");
                }
            }
        }
        //Substring(), IndexOf(), EndsWith(), Contains(), Split(), Trim()

        /*
        Count and output how many vowels were in the string. 
        */
        public static int VowelsCountOutput(string Input)
        {

            int count = 0;

            foreach (char letter in Input)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':

                        count += 1;
                        break;
                }
            }
            return count;
        }

        /*
        Count and output how many consonants were in the string.
               */
        public static int ConsonantsCountOutput(string Input)
        {
           // int difference = 0;
            int count = 0;

            foreach (char letter in Input)
            {
                switch (letter)
                {
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':

                        count += 1;
                        break;
                }
            }
            //difference = Input.Length - count;
            return count;
        }

        /*
        Remove all the vowels and output the text. 
        */
        public static string FindAndRemoveVowels(string Input)
        {
            Input = Input.Replace("a", "").
                Replace("e", "").
                Replace("i", "").
                Replace("o", "").
                Replace("u", "").
                Replace("A", "").
                Replace("E", "").
                Replace("I", "").
                Replace("O", "").
                Replace("U", "");

            return Input;
        }
    }
}
