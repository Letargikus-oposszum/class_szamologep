namespace ClassWork0921;

public class Calculator
{
    public void szorz()
    {
        Console.WriteLine("Adj meg egy számot: ");
        string a = Console.ReadLine();
        int szam1 = int.Parse(a);

        Console.WriteLine("Adj meg egy újabb számot: ");
        string b = Console.ReadLine();
        int szam2 = int.Parse(b);

        Console.WriteLine(szam1 * szam2);
    }
    public void osztas()
    {
        Console.WriteLine("Adj meg egy számot: ");
        string a = Console.ReadLine();
        int szam1 = int.Parse(a);

        Console.WriteLine("Adj meg egy újabb számot: ");
        string b = Console.ReadLine();
        int szam2 = int.Parse(b);

        Console.WriteLine(szam1 / szam2);

    }
    public void Összeg()
    {
        Console.WriteLine("Adj meg egy számot: ");
        string a = Console.ReadLine();
        int szam1 = int.Parse(a);

        Console.WriteLine("Adj meg egy újabb számot: ");
        string b = Console.ReadLine();
        int szam2 = int.Parse(b);

        Console.WriteLine(szam1 + szam2);
    }
    public void kivonas()
    {
        Console.WriteLine("Adj meg egy számot: ");
        string a = Console.ReadLine();
        int szam1 = int.Parse(a);

        Console.WriteLine("Adj meg egy újabb számot: ");
        string b = Console.ReadLine();
        int szam2 = int.Parse(b);

        Console.WriteLine(szam1 - szam2);

    }
    public void masodfok() 
    {
        while (true)
        {
        Console.WriteLine("Adj meg egy számot: ");
        string szam1 = Console.ReadLine();
        int a = int.Parse(szam1);
        
            if (a == 0)
            {
                Console.WriteLine("Ez az érték nem lehet 0!");
                break;
            }
            else
            {
                Console.WriteLine("Adj meg egy újabb számot: ");
                string szam2 = Console.ReadLine();
                int b = int.Parse(szam2);

                Console.WriteLine("Adj meg egy újabb számot: ");
                string szam3 = Console.ReadLine();
                int c = int.Parse(szam3);

                if ((b * b) - 4 * a * c < 0) 
                {
                    Console.WriteLine("A Diszkrimináns kisebb mint 0 -- NINCS Mo.");
                    break;
                }
                else
                {
                    double result1 = (double)((-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a));
                    Console.WriteLine("Ennek a szarnak az eredménye: ");
                    Console.WriteLine(result1);
                    double result2 = (double)((-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a));
                    Console.WriteLine("Ennek a szarnak az eredménye: ");
                    Console.WriteLine(result2);
                    break;
                }
                    
            }
        }
    }
}
