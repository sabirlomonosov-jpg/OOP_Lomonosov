using System;

public abstract class Isik
{
    public string Nimi { get; set; }

    private int sünniaasta;

    public int Sünniaasta
    {
        get { return sünniaasta; }
        set
        {
            if (value > 1900 && value <= DateTime.Now.Year)
                sünniaasta = value;
            else
                Console.WriteLine("Vigane sünniaasta!");
        }
    }

    public int Vanus
    {
        get { return DateTime.Now.Year - sünniaasta; }
    }

    public abstract void Kirjelda();
}