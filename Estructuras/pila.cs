namespace PRestaurante.Estructuras
{//1
    public class Pila<T>
    {//2
        private Nodo<T> cima;
        public void Apilar(T valor)
        {//3
            Nodo<T> nuevo = new Nodo<T>(valor);
            nuevo.Siguiente = cima;
            cima = nuevo;

        }//3

        public T Desapilar()
        {//4

            if (cima == null)

                throw new InvalidOperationException("La pila está vacía");


            T valor = cima.Valor;
            cima = cima.Siguiente;
            return valor;

        }//4

        public T Cima()
        {//5
            if (cima == null)
                throw new InvalidOperationException("La pila está vacía");
            return cima.Valor;


        }//5
        
        public bool EstaVacia()
        {
            return cima == null;
        }


    }//2

    
}//1