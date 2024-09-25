using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Objektorientering.Opg3_2
{
    internal class App
    {
        static void Main(string[] args)
        {
            Mekaniker mekaniker1 = new Mekaniker("Benjamin","Solvej 3",new CprNr("19980208","1235"),"101",500,2019);
            Vaerkfoerer vaerkfoerer1 = new Vaerkfoerer("Mikkel", "Bumlevej 14", new CprNr("18970208", "7265"), "102", 200, 1982,1991,600);
            Synsmand synsmand1 = new Synsmand("Nikolaj", "Rævegade", new CprNr("19301008", "1635"), "103", 300, 1984, 0);

            Console.WriteLine(mekaniker1);
            mekaniker1.Adresse = "Månevej 44";
            Console.WriteLine(mekaniker1);

            // Opgave 3.3
            Console.WriteLine("Ugeløn mekaniker: "+mekaniker1.BeregnUgeLøn());
            Console.WriteLine("Ugeløn værkfører: "+vaerkfoerer1.BeregnUgeLøn());
            Console.WriteLine("Ugeløn synsmand: "+synsmand1.BeregnUgeLøn());

            // Opgave 3.5
            var medarbejderListe = new MedarbejderListe<CprNr>();
            medarbejderListe.AddElement(mekaniker1.CprNr,mekaniker1);
            medarbejderListe.AddElement(vaerkfoerer1.CprNr, vaerkfoerer1);

            Console.WriteLine("Medarbejderliste antal: "+medarbejderListe.Size());
            var søgEfter = new CprNr("19980208", "1235");
            Console.WriteLine("Fundet mekaniker1? "+medarbejderListe.GetElement(søgEfter));

            var medarbejderListe2 = MedarbejderlisteInit();

            // Opgave 3.6
            var medarbejderListe3 = new MedarbejderListe<String>();
            medarbejderListe3.AddElement(mekaniker1.Adresse, mekaniker1);
            medarbejderListe3.AddElement(vaerkfoerer1.Adresse, vaerkfoerer1);
            Firma firma1 = new Firma("Autoværkstedet", "1234567890", "Motorvej");
            medarbejderListe3.AddElement(firma1.Adresse, firma1);
            Console.WriteLine(medarbejderListe3.GetElement(firma1.Adresse).Adresse); //Motorvej

        }

        public static MedarbejderListe<string> MedarbejderlisteInit() {
            Mekaniker mekaniker1 = new Mekaniker("Benjamin", "Solvej 3", new CprNr("19980208", "1235"), "101", 500, 2019);
            Vaerkfoerer vaerkfoerer1 = new Vaerkfoerer("Mikkel", "Bumlevej 14", new CprNr("18970208", "7265"), "102", 200, 1982, 1991, 600);

            var medarbejderListe2 = new MedarbejderListe<string>();
            medarbejderListe2.AddElement(mekaniker1.MedarbejderNr, mekaniker1);
            medarbejderListe2.AddElement(vaerkfoerer1.MedarbejderNr, vaerkfoerer1);

            return medarbejderListe2;
        }
    }
}
