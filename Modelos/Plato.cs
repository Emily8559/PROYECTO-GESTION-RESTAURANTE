namespace PRestaurante.Modelos
{//1
    public class Plato
    {//2
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Plato(string codigo, string nombre, string descripcion, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"{Nombre} - ${Precio} (Código): {Codigo})";
        }
    }//2
}//1