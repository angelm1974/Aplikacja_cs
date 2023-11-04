using System.IO;
internal class Program
{

    static int a=0, b=0;
    static string pobrana;

    /// <summary>
    /// Procedura główna aplikacji
    /// </summary>
    /// <param name="args">Parametry wejsciowe w postaci tablicy tekstowej </param>
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Podaj liczbę a: ");
            a = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine()!);

            Console.WriteLine(a+b);
        }
        catch (Exception)
        {
            Console.WriteLine("Stary podałeś coś nie tak.");

        }



        Console.ReadLine();

    }
    
    

}