using System;

public class Pila<E> : Colas<E> 
{

    public Pila(List<E> cola) : base(cola) {}

    public override void Remove() {
        int LAST_ELEMENT = (cola.Count() - 1);

        this.cola.RemoveAt(LAST_ELEMENT);

    }

    public override E GetElement()
    {
        int LAST_ELEMENT = (cola.Count() - 1);

        E result = this.cola[LAST_ELEMENT];
        this.cola.RemoveAt(LAST_ELEMENT);
        return result;
    }


}
