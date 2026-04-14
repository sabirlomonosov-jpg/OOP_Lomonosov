using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lomonosov
{
    public abstract class Isik
    {
        public string Nimi { get; set; }
        public string Aine { get; set; }


        // Abstraktne meetod – sisu puudub, alamklassid PEAVAD selle ise looma
        public abstract void Kirjelda();
    }

    public class Õpetaja : Isik
    {
        public string Aine { get; set; }

        // override kirjutab abstraktse meetodi üle
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }
    }

    public class Õpilane : Isik
    {
        public int Klass { get; set; }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpilane {Nimi} ja käin {Klass}. klassis.");
        }
    }

}
