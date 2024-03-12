// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using System;


KodePos nt = new KodePos();
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

}