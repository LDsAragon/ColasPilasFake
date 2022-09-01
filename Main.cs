using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;


public class Runer_class
{
    private static void Main(string[] args)
    {

        String tab = "\t";

        // EJEMPLO DE COLAS STRING  

        Console.Write("\n\nEJEMPLO DE COLAS STRING\n\n");

        List<String> listaPrueba = new List<String> { "Hola", "Mundo" };

        Colas<String> colas = new Colas<String>(listaPrueba);
        
        colas.PutElement("Chau");
        colas.Remove();
        Console.WriteLine(tab + "ToStrings " + colas.getCSV());

        Console.WriteLine(tab + "GetElement " + colas.GetElement()); 

        Console.WriteLine(tab + "Peek " + colas.Peek());

        Console.WriteLine(tab + "Contains Chau ? " + colas.Contains("Chau"));

        Console.WriteLine(tab + "GetTypes " + colas.GetTypes());

        Colas<String> bseLIN =  colas;
        bseLIN.PutElement("Arturo");
        Console.WriteLine(tab + bseLIN.getCSV() );
        Console.Write(""+ tab + "ToArray ");
        Console.Write("  [");
        foreach (String i in bseLIN.ToArray())
        {
            Console.Write(i);
        }
        Console.Write("]\n");

        Console.WriteLine(tab + "Count " + colas.Count());

        Console.WriteLine(tab + "GetEnumerator " + colas.GetEnumerator(3));

        // EJEMPLO DE COLAS INT 

        Console.WriteLine("\n\n\nEJEMPLO DE COLAS INT\n");

        List<int> listaInt = new List<int> { 666, 42 };

        Colas<int> colaINT = new Colas<int>(listaInt) ;

        Console.WriteLine(tab + colaINT.getCSV() );

        colaINT.PutElement(78);

        Console.WriteLine(tab + colaINT.getCSV());


        // EJEMPLO DE PILAS STRING

        Console.WriteLine("\n\n\nEJEMPLO DE PILAS STRING\n");

        Pila<String> coolPila = new Pila<String>(new List<String> { "Hola", "Mundo" });
        Console.WriteLine(tab + coolPila.getCSV() );

        coolPila.Remove();

        Console.WriteLine(tab + coolPila.getCSV());

        coolPila.PutElement("Arturo");

        Console.WriteLine(tab + coolPila.getCSV());

    }
}
