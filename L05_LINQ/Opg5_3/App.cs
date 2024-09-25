namespace L05_LINQ.Opg5_3
{

    public class App
    {
        static void Main(string[] args)
        {
            Exercise1();
        }

        public static void Exercise1()
        {
            List<Person> people1;
            try
            {
                people1 = Person.ReadCSVFile(@"C:\Datamatiker Uddannelse\4. Semester\C#\data1.csv");

                var liste2 = people1.FindAll(p => p.Score < 2);
                foreach (var person in liste2)
                {
                    Console.WriteLine(person.ToString());
                }
                Console.WriteLine("----------");

                var liste3 = people1.FindAll(p => p.Score % 2 == 0);
                foreach (var person in liste3)
                {
                    Console.WriteLine(person.ToString());
                }
                Console.WriteLine("----------");

                var liste4 = people1.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
                foreach (var person in liste4)
                {
                    Console.WriteLine(person.ToString());
                }
                Console.WriteLine("----------");

                var liste5 = people1.FindAll(p => p.Weight % 3 == 0);
                foreach (var person in liste5)
                {
                    Console.WriteLine(person.ToString());
                }
                Console.WriteLine("----------");


                // Opg 5.4 ---------------------

                Console.WriteLine(people1.FindIndex(p => p.Score == 3));
                Console.WriteLine(people1.FindIndex(p => p.Age < 10 && p.Score == 3));
                Console.WriteLine(people1.FindAll(p => p.Age < 10 && p.Score == 3).Count);
                Console.WriteLine(people1.FindIndex(p => p.Age < 8 && p.Score == 3)); // -1 betyder ikke fundet


                // Opg 5.6 ---------------------
                Console.WriteLine("----------");

                people1.SetAcceptedP(p => p.Score >= 6 && p.Age <= 40);
                foreach (var person in people1)
                {
                    Console.WriteLine(person.ToString());
                }


                // Opg 5.7 ---------------------
                Console.WriteLine("--------- Opg 5.7 ---------");
                var s = from p in people1
                        orderby p.Score ascending
                        select p;

                foreach (var person in s)
                {
                    Console.WriteLine(person.ToString());
                }

                var s2 = from p in people1
                        orderby p.Age descending
                        select p;

                foreach (var person in s2)
                {
                    Console.WriteLine(person.ToString());
                }


                // Opg 5.8 ---------------------
                Console.WriteLine("--------- Opg 5.8 ---------");

                int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

                var talListe = from tal in numbers
                                where tal.ToString().Length == 2
                                orderby tal
                                select tal;

                foreach (var tal in talListe)
                {
                    Console.WriteLine(tal);
                }
                Console.WriteLine("----------");

                var talListe2 = from tal in numbers
                               where tal.ToString().Length == 2
                               orderby tal descending
                               select tal;

                foreach (var tal in talListe2)
                {
                    Console.WriteLine(tal);
                }

                Console.WriteLine("----------");
                foreach (var tal in talListe)
                {
                    Console.WriteLine(tal.ToString());
                }

                Console.WriteLine("----------");
                var talListe3 = from tal in numbers
                                where tal.ToString().Length == 2
                                orderby tal descending
                                select tal;

                foreach (var tal in talListe3)
                {
                    if (tal % 2 == 0) Console.WriteLine(tal + " even");
                    else Console.WriteLine(tal + " uneven");
                }



                // Opg 5.9 ---------------------
                Console.WriteLine("--------- Opg 5.9 ---------");

                people1.Reset();

                //foreach (var person in people1) Console.WriteLine(person); 


                // Opg 5.10 ---------------------
                Console.WriteLine("--------- Opg 5.10 ---------");

                Random rdn = new Random();
                List<int> liste = new List<int>();
                for (int i = 0; i < 100; i++) liste.Add(rdn.Next(100));

                //foreach (int i in liste)
                //{
                //Console.WriteLine(i); }

                var antal = liste.Count(tal => tal % 2 == 1);

                Console.WriteLine(antal);

                Console.WriteLine("----------");

                var antalUnik = liste.Distinct().Count();
               
                Console.WriteLine(); 
                Console.WriteLine("Antal unik: "+antalUnik);

                Console.WriteLine("----------");

                var liste6 = liste.Where(tal => tal % 2 == 1).Take(3);
                foreach (var tal in liste6) Console.WriteLine(tal);
                
                Console.WriteLine("----------");

                var liste7 = liste.Distinct().Take(3);
                foreach (var tal in liste7) Console.WriteLine(tal);

                // Opg 5.11 ---------------------
                Console.WriteLine("--------- Opg 5.11 ---------");


            }

            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
                Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
            }


        }
    }


}