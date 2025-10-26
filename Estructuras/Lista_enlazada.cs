namespace PRestaurante.Estructuras
{//1
    public class Nodo<T>
    {//2
        public T Valor { get; set; }
        public Nodo<T>? Siguiente { get; set; }
        public Nodo(T valor)
        {//3
            Valor = valor;
            Siguiente = null;

        }//3
    }//2
        public class Listaenlazada<T>
    {//4
        private Nodo<T>? cabeza;
        public void Insertar(T valor)
        {//5
            Nodo<T> nuevo = new Nodo<T>(valor);
            if (cabeza == null)
                cabeza = nuevo;
            else
            {//6
                Nodo<T> actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
                
            }//6

             
        }//5
    }//4

    
}