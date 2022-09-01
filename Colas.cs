using System.Drawing;
using System.Xml.Linq;
using System;

internal class Colas<E>
{
    private List<E> cola;
    private int FIRST_ELEMENT = 0;
    public Colas() { }
    public Colas(List<E> cola) { this.cola = cola; }

    public void PutElement(E element) { this.cola.Add(element); } // Coloca un elemento en la cola

    public void Remove() { this.cola.RemoveAt( FIRST_ELEMENT ); } // Remueve el primer elemento de la cola
    
    public E Peek() { return cola[FIRST_ELEMENT]; } //Peek: mira el valor de la cabeza pero sin extraer.
    public void Clear() { this.cola = new List<E>(); } //Clear: borra todo el contenido de la cola.
    public bool Contains(E searcher) { return cola.Contains(searcher); } //Contains: indica si un cierto elemento está en la cola.
    public Type GetTypes() { return cola.GetType(); } //GetType: para saber de que tipo son los elementos almacenados en la cola.
    public String getCSV() {
        String aux = "";
        for (int i = 0; i < cola.Count(); i++)
        {

            if (i != FIRST_ELEMENT)
            {
                aux += "," + cola[i];
            }
            else {
                aux += cola[i];
            }
        }
        return aux; 
    } //ToString: devuelve el elemento actual convertido en un string.
    public E[] ToArray() { return cola.ToArray();  } //ToArray.devuelve toda la cola convertida en un array.
    public E GetEnumerator(int element)  {
        try
        {
            return cola[element];
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Element not found, returning first element instead");
            return cola[FIRST_ELEMENT] ;
        }
        
    } //GetEnumerator: permite usar enumeradores para recorrer la pila.
    public int Count() { return cola.Count(); } //Count: indica cuantos elementos contiene.
    public E GetElement()  // retorna el primer elemento de la cola y lo remueve
    {
        E result = this.cola[FIRST_ELEMENT];
        this.cola.RemoveAt(FIRST_ELEMENT);
        return result;
    }

}