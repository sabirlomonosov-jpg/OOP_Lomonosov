public class Õpetaja : Isik
{
    public string Aine { get; set; }
    public double BaasPalk { get; set; }

    public void Õpeta()
    {
        Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
    }

    public override void Kirjelda()
    {
        Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan {Aine}.");
    }

    public virtual double ArvutaPalk()
    {
        return BaasPalk;
    }
}