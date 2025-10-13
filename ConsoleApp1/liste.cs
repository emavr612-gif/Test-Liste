using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    //Klasa Osoba - Definirajte osnovne atribute osobe: Atributi: ime, prezime, datum_rođenja, matični_broj.
    class Osoba 
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodenja { get; set; }
        public string MaticniBroj { get; set; }

    }

    //Klasa Zaposlenik - Nasljeđuje klasu Osoba i dodatno sadrži: Atributi: datum_zaposlenja, pozicija, plaća.

    class Zaposlenik : Osoba
    {
        public DateTime DatumZaposljenja { get; set; }
        public string Pozicija { get; set; }
        public string Placa { get; set; }

        public Zaposlenik(string ime, string prezime, DateTime dr, string mb, DateTime dz, string pozicija, string placa)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodenja = dr;
            MaticniBroj = mb;
            DatumZaposljenja = dz;
            Pozicija = pozicija;
            Placa = placa;
        }
    }


    //Klasa VoditeljProjekta - Nasljeđuje klasu Zaposlenik i dodatno sadrži: Atributi: naziv_projekta, lista_clanova, budzet.
    //Konstruktor klase: Pri unosu voditelja projekta unositi broj članova tima n, a zatim unositi informacije o svakom članu tima te ih dodavati u listu članova.

    class VoditeljProjekta : Zaposlenik
    {
        public string NazivProjekta;
        public double budzet;
        public List<Clan> clanovi();

        public VoditeljProjekta()
        {
            Console.Write($"Unesite broj clanova: ");
            int n = Console.ReadLine();
        }

        private void NewMethod(int i)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Upisite piodatke clana #{i + 1}: ");

                Console.Write($"Ime: ");
                string ime = Console.ReadLine();

                Console.Write($"Prezime: ");
                string prezime = Console.ReadLine();

                Console.Write($"Datum rodenja: ");
                DateTime dr = DateTime.Parse(Console.ReadLine());

                Console.Write($"Maticni broj: ");
                string mb = Console.ReadLine();

                Console.Write($"Datum zaposljavanja: ");
                DateTime dz = DateTime.Parse(Console.ReadLine());

                Console.Write($"Pozicija: ");
                string pozicija = Console.ReadLine();

                Console.Write($"Placa: ");
                string placa = Console.ReadLine();

                Console.Write($"Naziv projekta: ");
                string np = Console.ReadLine();

                clan c = new clan(ime, prezime, dr, mb, dz, pozicija, placa, np);
                clanovi.Add(c);

            }
        }

        // a) Dodaj člana tima - Metoda za dodavanje novog člana u tim.
        public void DodajClana()
        {
            Clan b = new Clan(Ime, Prezime, DatumRodenja, MaticniBroj, DatumZaposljenja, Pozicija, Placa, NazivProjekta);
            clanovi.Add(c);
        }


        //Ukloni člana tima - Metoda koja prima matični broj člana i uklanja ga iz tima.
        public void UkloniClana()
        {
            Console.Write($"Unesite maticni broj clana kojeg zelite izbrisati: ");
            string mzb = Console.ReadLine();

            for (int i = 0; i < clanovi.Count; i++)
            {
                if (mzb = clanovi[i].mb)
                {
                    clanovi.RemoveAt(i);
                }
            }
        }

        //Prosječna plaća tima - Metoda koja izračunava i ispisuje prosječnu plaću svih članova tima.

        public double ProsjecnaPlaca()
        {
            double ukupnoP = 0;
            for (int i = 0; i < clanovi.Count; i++)
            {
                ukupnoP += clanovi[i].placa;
            }
            double prosjekP = ukupnoP / clanovi.Count;
            return prosjek;
        }

        // Starost najmlađeg člana u odnosu na prosjek - Metoda koja ispisuje razliku u godinama između najmlađeg člana i prosječne starosti tima.

        public void RazlikaNajmladeg()
        {
            double ukupnoG = 0;
            for (int i = 0; i < clanovi.Count; i++)
            {
                ukupnoG += clanovi[i].DatumRodenja.Year;
            }
            double prosjekG = ukupnoG / clanovi.Count;


            Zaposlenik najmladi = clanovi(0);
            for (int i = 0; i < clanovi.Count; i++)
            {
                if (clanovi[i].DatumRodenja > najmladi.DatumRodenja)
                    najmladi = clanovi[i];
            }

            return najmladi.DatumRodenja.Year - prosjekG;
        }

    }

}
