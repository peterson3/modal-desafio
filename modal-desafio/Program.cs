using System;
using System.Collections.Generic;

namespace modal_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/***Desafio Modal***/");
            var words = System.IO.File.ReadAllLines("in.txt");

            foreach (var word in words)
            {
                //Console.WriteLine(word + " -> "
                //    + WordToIntArray(word)[0] + " "
                //    + WordToIntArray(word)[1] + " "
                //    + WordToIntArray(word)[2] + " "
                //    + WordToIntArray(word)[3] + " "
                //    + WordToIntArray(word)[4] + " -> "
                //    + IntArrayToWord(WordToIntArray(word)));

                //Console.WriteLine(Encrypt(word).ToString());

                //Console.WriteLine(word + " -> " + GetNextWord(word));
                Console.WriteLine(word + " -> " + Encrypt(word));
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        private static string GetNextWord(string word)
        {
            var charCodes = WordToIntArray(word);

            if (charCodes[4] != 26)
            {
                charCodes[4]++;
            }
            else
            {
                charCodes[4] = 1;
                if (charCodes[3] != 26)
                {
                    charCodes[3]++;
                }
                else
                {
                    charCodes[3] = 1;
                    if (charCodes[2] != 26)
                    {
                        charCodes[2]++;
                    }
                    else
                    {
                        charCodes[2] = 1;
                        if (charCodes[1] != 26)
                        {
                            charCodes[1]++;
                        }
                        else
                        {
                            charCodes[1] = 1;
                            if (charCodes[0] != 26)
                            {
                                charCodes[0]++;
                            }
                            else
                            {
                                //do nth
                            }
                        }
                    }
                }
            }
            
            return IntArrayToWord(charCodes);
        }

        private static string IntArrayToWord(int[] codes)
        {
            List<char> chars = new List<char>();

            foreach (var codeChar in codes)
            {
                if (codeChar != 0)
                    chars.Add(Number2Char(codeChar));
            }

            return String.Concat(chars);
        }

        private static int[] WordToIntArray(string word)
        {
            List<int> codes = new List<int>();
            foreach (var character in word.ToCharArray())
            {
                codes.Add(EncryptChar(character));
            }

            int[] codeArray = new int[5];
            var zeroComplete = 5 - (codes.Count % 5);

            for (int i=0; i<zeroComplete; i++)
                codes.Insert(0, 0);

            return codes.ToArray();
        }

        private static int Encrypt(string word)
        {
            if (!isValid(word)) return 0;

            var startString = "a";
            int value = 1;
            while (startString != word)
            {
                startString = GetNextWord(startString);
                if (isValid(startString))
                    value++;
                //Console.WriteLine("DEBUG - " + startString);
            }
            return value;
        }

        private static int EncryptChar(char character)
        {
            return (int)character % 32;
        }

        private static char Number2Char(int number, bool isCaps = false)
        {
            Char c = (Char)((isCaps ? 65 : 97) + (number - 1));
            return c;
        }

        private static bool isValid(string word)
        {
            var chars = word.ToCharArray();
            var charsValues = new List<int>();
            foreach (var character in chars)
            {
                charsValues.Add(EncryptChar(character));
            }

            return IsSorted(charsValues.ToArray());
        }

        private static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] >= arr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
