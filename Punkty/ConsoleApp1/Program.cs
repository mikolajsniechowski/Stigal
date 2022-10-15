using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj x i y punktu 1: ");
        Punkt punkt1 = NowyPunkt();
        Console.WriteLine("Podaj x i y punktu 2: ");
        Punkt punkt2 = NowyPunkt();
        punkt1.Print();
        punkt2.Print();
        Console.WriteLine("Dystans pomiedzy podanymi punktami: "+Math.Round(DystansPomiedzyPunktami(punkt1,punkt2),2));
    }
    public static double DystansPomiedzyPunktami (Punkt p1, Punkt p2)
    {

        double wynik = (double)Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));
        return wynik;
        
    }
    public static Punkt NowyPunkt()
    {
        bool t = false;
        var doubles = new List<double>();
        do
        {
            doubles.Clear();
            string[] arrayst = Console.ReadLine().Split();
            if(arrayst.Length == 2)
            {
                foreach (string s in arrayst)
                {
                    if (double.TryParse(s, out double number))
                    {
                        doubles.Add(number);
                        t = false;
                    }
                    else
                    {
                        Console.WriteLine(s + " jest błędną wartością");
                        t = true;
                    }
                }
            }
            else
            {
                t = true;
                Console.WriteLine("Zla ilosc argumentow");
            }
        } while (t);
        
        return new Punkt(doubles[0],doubles[1]);    

    }
}