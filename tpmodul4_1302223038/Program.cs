﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //No 1
        KodePos kodePos = new KodePos();
        Console.Write("Masukan kelurahan pilihan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine(kodePos.GetKodePos(kelurahan));

        //No 2
        DoorMachine doorMachine = new DoorMachine();
        Console.Write("Masukkan perintah (Terkunci/Terbuka):");
        string perintah = Console.ReadLine();
        doorMachine.ChangeState(perintah);
    }
}


