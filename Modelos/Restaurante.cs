using System.Globalization;

namespace PRestaurante.Modelos
{//1
    public class Restaurante
    {//2
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string Dueno { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }

        public Restaurante(string nombre, string nit, string dueno, string direccion, string celular)
        {//3
            Nombre = nombre;
            Nit = nit;
            Dueno = dueno;
            Direccion = direccion;
            Celular = celular;

        }//3

        public override string ToString()
        {
            return $"Restaurante: {Nombre}, NIT: {Nit}, Dueño: {Dueno}, Dirección: {Direccion}, Celular: {Celular}";
        }
        
    }//2
    
}//1