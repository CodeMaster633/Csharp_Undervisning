class Opg5_1
{
    static void Main(string[] args)
    {

        int[] liste = { 1, 12, 3, 5, 6, 7, 9, 10, 2, 13, 14, 15, 16, 17 };

        List<int> liste2 = liste.ToList().FindAll(tal => tal % 2 == 0);

        liste2.ForEach(tal => Console.WriteLine(tal));

        int over15 = liste.ToList().FindLast(tal => tal > 15);

        Console.WriteLine("Sidste over 15: " + over15);

        int over15i = liste.ToList().FindLastIndex(tal => tal > 15);

        Console.WriteLine("Sidste over 15 index: " + over15i);


        // Opgave 5.2
        Console.WriteLine("----- Opgave 5.2 -----");

        //var liste3 = liste.Where(tal => tal % 2 == 0);
        var liste3 = from tal in liste
                     where tal % 2 == 0
                     select tal;

        foreach (int item in liste3)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------");

        var liste4 = liste.Where(tal => tal.ToString().Length == 2)
            .OrderBy(tal => tal);
        //var liste4 = from tal in liste
        //             where tal.ToString().Length == 2
        //             orderby tal
        //             select tal;


        foreach (int item in liste4)
        {
            Console.WriteLine(item);
        }
    }
}