using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj promien kola");
        string line;
        double promien;
        bool t = true;
        do 
        {
            line = Console.ReadLine();
        } while(!double.TryParse(line, out promien));
        Kolo kolo = new Kolo(promien);
        Console.WriteLine("Pole kola: "+Math.Round(kolo.Pole(),2));
        Console.WriteLine("Obwod kola " + Math.Round(kolo.Obwod(),2));
    }
   
}