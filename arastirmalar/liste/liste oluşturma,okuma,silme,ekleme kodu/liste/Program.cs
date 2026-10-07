using System.Collections;

class program 
{
    private static object hayvan;

    static void Main()
    {
        liste();
    }

    static void liste()
    {
        List<string> hayvanlar = new List<string>
            {
            "kedi",
            "köpek",
            "kuş",
            "balık",
            "salyangoz",
            "flamingo",
            "kaz"
        };
        // hayvanlar.Remove(hayvanlar[0]);//silmek için index numarası verilir.

        //hayvanlar.Insert(0, "aslan");//eklemek için index numarası verilir.

        // Console.WriteLine("Hayvanlar Listesi:");
        //Console.WriteLine(hayvanlar.Count + "tane hayvan var.")
        //Console.WriteLine(hayvanlar);
        foreach (string hayvan in hayvanlar)
        {
            Console.WriteLine(hayvan);
        }

    }



}