namespace Listacircularsimple
{
    class Nodo
    {
        private int dato;//Los nodos almacenaran un valor entero, para este ejemplo sera datos
        private Nodo siguiente; //Declaramos el puntero al siguiente nodo
        public int Dato //Ahora pasamos al encapsulamiento, lo cual permite obtener y establecer los valores para los nodos
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente //puntero, referencia
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo()
        {
            dato = 0;
            siguiente = this;
        }

        public Nodo(int dato, Nodo siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}