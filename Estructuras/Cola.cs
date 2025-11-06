namespace PRestaurante.Estructuras
{//1
    public class Cola<T>
    {//2
        private Nodo<T>? frente;
        private Nodo<T>? final;
        public void Encolar(T valor)
        {//3
            Nodo<T> nuevo = new Nodo<T>(valor);
            if (final == null)
            {//4
                frente = nuevo;
                final = nuevo;
            }//4
            else
            {//5
                final.Siguiente = nuevo;
                final = nuevo;
            }//5
        }//3

        public T Desencolar()
        { // 6
            if (frente == null)
                throw new InvalidOperationException("La cola está vacía.");

            T valor = frente.Valor;
            frente = frente.Siguiente;

            if (frente == null)
                final = null;

            return valor;
        }//6

        public T frente()
        public T Frente()
        {
            if (frente == null)
                throw new InvalidOperationException("La cola esta vacía");
            return frente.Valor;
        }

        public bool Estavacia()
        {
            return frente == null;
        }

    }//2
    
}//1