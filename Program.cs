using System.IO;
internal class Program
{
    /// <summary>
    /// Procedura główna aplikacji
    /// </summary>
    /// <param name="args">Parametry wejsciowe w postaci tablicy tekstowej </param>
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Kielbasa();
        Console.ReadLine();

    }

    /// <summary>
    /// 
    /// </summary>
    private static void Kielbasa()
    {
        Console.WriteLine($"Kielbasa");
/*
        TextReader tr = File.OpenText("D:\\Programy\\aplikacje_cs\\aplikacjakonsolowa1\\README.md");
        Console.WriteLine(tr.ReadToEnd());
*/
        Console.ReadLine();
    }

}