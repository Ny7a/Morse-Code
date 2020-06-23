using System;

namespace morse_code_week_2_day_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //get input from user
            string input;
            string morse = "";
            Console.WriteLine("Give me a word:");
            Console.WriteLine("");
            input = Console.ReadLine();
            input = input.ToLower();
            //give the input back to the user:
            Console.WriteLine("input is " + input);
            for (int i = 0; i < input.Length; i++)
            //string output= 
            //input.Replace('a',) ( '.-');
            {
                if (input[i] == 'a')
                // 'a' is a char or character
                //"a" is a string with just one character in it
                {
                    morse = morse + ".-";

                }
                else if (input[i] == 'b')
                {
                    morse = morse + "-...";
                }

                else if (input[i] == 'c')
                {
                    morse = morse + "-.-.";

                }
                else if (input[i] == 'd')
                {
                    morse = morse + "-..";
                }
                else if (input[i] == 'e')
                {
                    morse = morse + ".";
                }
                else if (input[i] == 'f')
                {
                    morse = morse + "..-.";
                }
                else if (input[i] == 'g')
                {
                    morse = morse + "--.";
                }
                else if (input[i] == 'h')
                {
                    morse = morse + "....";
                }
                else if (input[i] == 'i')
                {
                    morse = morse + "..";
                }
                else if (input[i] == 'j')
                {
                    morse = morse + ".---";
                }
                else if (input[i] == 'k')
                {
                    morse = morse + "-.-";
                }
                else if (input[i] == 'l')
                {
                    morse = morse + ".---";
                }
                else if (input[i] == 'm')
                {
                    morse = morse + "--";
                }
                else if (input[i] == 'n')
                {
                    morse = morse + "-.";
                }
                else if (input[i] == 'o')
                {
                    morse = morse + "---";
                }
                else if (input[i] == 'p')
                {
                    morse = morse + ".--.";
                }
                else if (input[i] == 'q')
                {
                    morse = morse + "--.-";
                }
                else if (input[i] == 'r')
                {
                    morse = morse + ".-.";
                }
                else if (input[i] == 's')
                {
                    morse = morse + "...";
                }
                else if (input[i] == 't')
                {
                    morse = morse + "-";
                }
                else if (input[i] == 'u')
                {
                    morse = morse + "..-";
                }
                else if (input[i] == 'v')
                {
                    morse = morse + "...-";
                }
                else if (input[i] == 'w')
                {
                    morse = morse + ".--";
                }
                else if (input[i] == 'x')
                {
                    morse = morse + "-..-";
                }
                else if (input[i] == 'y')
                {
                    morse = morse + "-.--";
                }
                else if (input[i] == 'z')
                {
                    morse = morse + "--..";
                }

                else
                {
                    Console.WriteLine("Unknown Character");
                }
                morse += " ";
                {
                    //  Console.WriteLine(i);
                    // i++;

                }

                {
                    Console.WriteLine("In morse, your word/phrase is:" + morse);
                }
                //for (int input = 0;  input <50;  input++)
                {

                }








            }
            //Console.WriteLine(morse)

        }
    }
}
