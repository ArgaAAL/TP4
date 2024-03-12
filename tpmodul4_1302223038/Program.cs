using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();
        Console.Write("Masukan kelurahan pilihan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine(kodePos.GetKodePos(kelurahan));
    }
}


