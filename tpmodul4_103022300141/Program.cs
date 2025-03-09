using System;
using tpmodul4_103022300141;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kode Pos Batununggal: " + KodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Samoja: " + KodePos.GetKodePos("Samoja"));
        Console.WriteLine("Kode Pos Tidak Ada: " + KodePos.GetKodePos("RandomKelurahan"));

        Console.WriteLine("");
        Console.WriteLine("");

        DoorMachine door = new DoorMachine(); // State Default : Terkunci
        door.BukaPintu();  
        door.KunciPintu(); 
        door.KunciPintu(); 
        door.BukaPintu();  
        door.BukaPintu(); 
    }
}
