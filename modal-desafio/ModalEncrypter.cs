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

            bool shouldSumNext = true;
            for (int i=charCodes.Length-1; (i>=0 && shouldSumNext); i--)
            {
                charCodes[i]++;
                charCodes[i] = charCodes[i] % 27;
                if (charCodes[i] == 0)
                {
                    charCodes[i] = 1;
                    shouldSumNext = true;
                }
                else
                    shouldSumNext = false;
            }
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

            if (zeroComplete < 5)
            {
                for (int i = 0; i < zeroComplete; i++)
                    codes.Insert(0, 0);
            }
       

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
