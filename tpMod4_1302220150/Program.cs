// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using System;


KodePos nt = new KodePos();
DoorMachine machine = new DoorMachine();

static void main()
{
    DoorMachine.changeState();
}
Console.WriteLine(nt.getKodePos("Kujangsari"));
Console.WriteLine("Hello, World!");


public class KodePos
{
    private Dictionary<string, string> kodePosData;

    public KodePos()
    {
        // Inisialisasi data kode pos
        kodePosData = new Dictionary<string, string>();
        kodePosData["Batununggal"] = "40266";
        kodePosData["Kujangsari"] = "40287";
        kodePosData["Mengger"] = "40267";
        kodePosData["Wates"] = "40256";
        kodePosData["Cijaura"] = "40287";
        kodePosData["Jatisari"] = "40286";
        kodePosData["Margasari"] = "40286";
        kodePosData["Sekejati"] = "40286";
        kodePosData["Kebonwaru"] = "40272";
        kodePosData["Maleer"] = "40274";
        kodePosData["Samoja"] = "40273";
    }
    public string getKodePos(string kelurahan)
    {
        if (kodePosData.ContainsKey(kelurahan))
        {
            return kodePosData[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan untuk kelurahan " + kelurahan;
        }
    }
};

public class DoorMachine
{
    enum Doormachine { Terkunci, Terbuka };
    Doormachine state = Doormachine.Terkunci;
    String[] ScreenName = { "Terkunci", "Terbuka" };
    
    public void changeState()
    {
        while (state == Doormachine.Terkunci)
        {
            Console.WriteLine(ScreenName[(int)state] + " SCREEN");
            Console.Write("Enter Command : ");

            string command = Console.ReadLine();
        }
    }
}