using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;


public class Runer_class
{
    private static void Main(string[] args)
    {
        
        // EJEMPLO DE COLAS STRING  
        
        List<String> listaPrueba = new List<String> { "Hola", "Mundo" };

        Colas<String> colas = new Colas<String>(listaPrueba);

        colas.PutElement("Chau");
        colas.Remove();
        Console.WriteLine("ToStrings " + colas.getCSV());

        Console.WriteLine("GetElement " + colas.GetElement()); 

        Console.WriteLine("Peek " + colas.Peek());

        Console.WriteLine("Contains Chau ? "+ colas.Contains("Chau"));

        Console.WriteLine("GetTypes " + colas.GetTypes());

        Colas<String> bseLIN =  colas;
        bseLIN.PutElement("Arturo");
        Console.WriteLine( bseLIN.getCSV() );
        Console.WriteLine("ToArray ");
        Console.WriteLine("[");
        foreach (String i in bseLIN.ToArray())
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("]");

        Console.WriteLine("Count " + colas.Count());

        Console.WriteLine("GetEnumerator " + colas.GetEnumerator(3));

        // EJEMPLO DE COLAS INT 

        List<int> listaInt = new List<int> { 666, 42 };

        Colas<int> colaINT = new Colas<int>(listaInt) ;

        Console.WriteLine(colaINT.getCSV() );

        colaINT.PutElement(78);

        Console.WriteLine(colaINT.getCSV());
        

        // EJEMPLO DE PILAS STRING

        Pila<String> coolPila = new Pila<String>(new List<String> { "Hola", "Mundo" });
        Console.WriteLine(coolPila.getCSV() );

        coolPila.Remove();

        Console.WriteLine(coolPila.getCSV());

        coolPila.PutElement("Arturo");

        Console.WriteLine(coolPila.getCSV());


    }
}
