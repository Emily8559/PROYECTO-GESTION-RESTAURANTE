namespace PRestaurante.Estructuras
{//1
    public class Pila<T>
    {//2
        private Nodo<T>? cima;
        public void Apilar(T valor)
        {//3
            Nodo<T> nuevo = new Nodo<T>(valor);
            nuevo.Siguiente = cima;
                throw new InvalidOperationException("La pila está vacía");
            if (cima == null)
            return cima.Valor;
}//1