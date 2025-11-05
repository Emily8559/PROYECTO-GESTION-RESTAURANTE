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

        public bool Eliminar(Func<T, bool> condicion)
        {//7
            if (cabeza == null) return false;

            if (condicion(cabeza.Valor))
            {//8
                cabeza = cabeza.Siguiente;
                return true;
            }//8

            Nodo<T> actual = cabeza;
            while (actual.Siguiente != null)
            {//9
                if (condicion(actual.Siguiente.Valor))
                {//10
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }//10
                actual = actual.Siguiente;
            }//9
            return false;
        } // 7

        public T? Buscar(Func<T, bool> condicion)
        {//8
            Nodo<T>? actual = cabeza;
            while (actual != null)
            {//9
                if (condicion(actual.Valor))
                    return actual.Valor;
                actual = actual.Siguiente;
            }//9
            return default;
        } // 8

        public void Recorrer(Action<T> accion)
        {//9
            Nodo<T>? actual = cabeza;
            while (actual != null)
            {//10
                accion(actual.Valor);
                actual = actual.Siguiente;
            }//10
        }//9
        
        public bool Vacia()
        {
            return cabeza == null;
        }
    }//4

    
}