﻿using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Keys ve Values değerleri string olacak sözlüğümüzü oluşturduk.
            MyDictionary<string, string> openWith = new MyDictionary<string, string>();

            //Sözlüğümüze anahtar ve değer değişkenlerimizi atıyoruz.
            openWith.Add("mp4", "GOM.exe");
            openWith.Add("png", "Fireworks.exe");
            openWith.Add("cs", "devenv.exe");
            openWith.Add("txt","notepad.exe");
            openWith.Add("jpg", "mspaint.exe");
            openWith.Add("doc", "WINWORD.EXE");

            //Eklenen elemanlar listeleniyor.
            openWith.WriteData();

            Console.WriteLine("---------------------------------");
            //Silme işlemi için key value değerleri alınıyor.
            string DKey, DValue;
            Console.Write("Silinecek elemanın anahtar sözcüğü = ");
            DKey = Console.ReadLine();
            Console.Write("Anahtar sözcüğe ait olan değer = ");
            DValue = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            //Silme metodu çalıştırılıyor.
            openWith.Delete(DKey, DValue);

            //Eklenen elemanlar listeleniyor.
            openWith.WriteData();

        }
    }
}
