using System;
using System.Collections.Generic;
using System.Text;

namespace modal_desafio
{
   public class ModalEncrypter
    {
        public string GetNextWord(string word)
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
                            Console.ReadKey();
                            charCodes[1] = 1;
                            if (charCodes[0] != 26)
                            {
                                Console.ReadKey();
                                charCodes[0]++;
                            }
                            else
                            {
                                Console.ReadKey();
                                //do nth
                            }
                        }
                    }
                }
            }

            Console.WriteLine("NEXT: [0]= " + charCodes[0] + " " +
                           "[1]= " + charCodes[1] + " " +
                           "[2]= " + charCodes[2] + " " +
                           "[3]= " + charCodes[3] + " " +
                           "[4]= " + charCodes[4]);


            return IntArrayToWord(charCodes);
        }

        public string IntArrayToWord(int[] codes)
        {
            List<char> chars = new List<char>();

            foreach (var codeChar in codes)
            {
                if (codeChar != 0)
                    chars.Add(Number2Char(codeChar));
            }

            return String.Concat(chars);
        }

        public int[] WordToIntArray(string word)
        {
            List<int> codes = new List<int>();
            foreach (var character in word.ToCharArray())
            {
                codes.Add(EncryptChar(character));
            }

            int[] codeArray = new int[5];
            var zeroComplete = 5 - (codes.Count % 5);

            for (int i = 0; i < zeroComplete; i++)
                codes.Insert(0, 0);

            return codes.ToArray();
        }

        public int Encrypt(string word)
        {
            if (!isValid(word)) return 0;

            var startString = "a";
            int value = 1;
            while (startString != word)
            {
                startString = GetNextWord(startString);

                if (isValid(startString))
                    value++;
                //Console.WriteLine("nextString= " + startString + " ---  word= " + word);
            }
            return value;
        }

        public int EncryptChar(char character)
        {
            return (int)character % 32;
        }

        public char Number2Char(int number, bool isCaps = false)
        {
            Char c = (Char)((isCaps ? 65 : 97) + (number - 1));
            return c;
        }

        public bool isValid(string word)
        {
            var chars = word.ToCharArray();
            var charsValues = new List<int>();
            foreach (var character in chars)
            {
                charsValues.Add(EncryptChar(character));
            }

            return IsSorted(charsValues.ToArray());
        }

        public bool IsSorted(int[] arr)
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
