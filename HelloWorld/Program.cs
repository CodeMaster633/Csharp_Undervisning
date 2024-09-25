// See https://aka.ms/new-console-template for more information
//using HelloWorld;

//Console.WriteLine("Hello, World!");

//Person person = new Person("Ole");

//Console.WriteLine(person.Fornavn);
//person.Fornavn = "Ib";
//Console.WriteLine(person);


using MyLibrary;
using HelloWorld;

class Program {
    public static void Main(string[] args) {

        MyList liste = new MyList();

        liste.AddNumber(1);
        liste.AddNumber(2); 
        liste.AddNumber(3);

        liste.PrintNumbers();
        

        liste.RandomNumbers();
        liste.PrintNumbers();

       

        //var fido = new Animal("hund");
        //Console.WriteLine("fido er en hund? " + fido.IsDog());


        //bool aktiv = true;

        //List<Animal> dyr = new List<Animal>();

        //while (aktiv) { 
        //    Console.WriteLine("Indtast et dyr: ");
        //    string input = Console.ReadLine();
        //    if (input == "0") {
        //        aktiv = false;
        //    } else {
        //    dyr.Add(new Animal(input)); 
        //    }
        //}



    }
}