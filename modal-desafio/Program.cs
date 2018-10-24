using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace modal_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/***Desafio Modal***/\n");
            var words = System.IO.File.ReadAllLines("in.txt");
            var modalEncrypter = new ModalEncrypter();

            foreach (var word in words)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                var encrypted = modalEncrypter.Encrypt(word);
                timer.Stop();
                Console.WriteLine(word + "\t->\t" + encrypted.ToString() + " \t EncTime: " + timer.Elapsed.ToString());
            }
            Console.ReadKey();
        }


    }
}
