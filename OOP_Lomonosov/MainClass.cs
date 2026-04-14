using System;

class MainClass
{
    static void Main(string[] args)
    {
        
        Õpetaja õpetaja = new Õpetaja();
        õpetaja.Nimi = "Mari";
        õpetaja.Sünniaasta = 1980;
        õpetaja.Aine = "Matemaatika";

        
        Õpilane õpilane = new Õpilane();
        õpilane.Nimi = "Jaan";
        õpilane.Sünniaasta = 2007;
        õpilane.Klass = 10;
        õpilane.Kool = "Tallinna Kool";

        
        Console.WriteLine("=== Õpetaja ===");
        õpetaja.Kirjelda();
        õpetaja.Õpeta();
        Console.WriteLine($"Vanus: {õpetaja.Vanus}");

        Console.WriteLine();

        Console.WriteLine("=== Õpilane ===");
        õpilane.Kirjelda();
        õpilane.Õpi();
        Console.WriteLine($"Vanus: {õpilane.Vanus}");

        Console.WriteLine();

        
        Console.WriteLine("=== Polümorfism ===");

        Isik[] inimesed = { õpetaja, õpilane };

        foreach (Isik inimene in inimesed)
        {
            inimene.Kirjelda(); 
        }

        Console.ReadLine();
    }
}