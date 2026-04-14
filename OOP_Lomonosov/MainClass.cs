using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lomonosov
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Isik inimene1 = new Isik();
            inimene1.Nimi = "Mati";
            inimene1.Sünniaasta = 2009;
            inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...
        }
    }
}
