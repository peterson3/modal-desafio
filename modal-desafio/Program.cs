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
            var modalEncrypter = new ModalEncrypter();

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
                Console.WriteLine(word + " -> " + modalEncrypter.Encrypt(word));
            }
            Console.ReadKey();
        }


    }
}
