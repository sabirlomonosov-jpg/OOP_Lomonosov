public class Õpilane : Isik
{
    public int Klass { get; set; }
    public string Kool { get; set; }

    public void Õpi()
    {
        Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
    }

    public override void Kirjelda()
    {
        Console.WriteLine($"Mina olen õpilane {Nimi} ja käin {Klass}. klassis.");
    }
}