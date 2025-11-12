namespace PRestaurante.Modelos
{//1
    public class Cliente
    {//2
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Cliente(string cedula, string nombre, string celular, string email)
        {
            Cedula = cedula;
            NombreCompleto = nombre;
            Celular = celular;
            Email = email; 
        }
    }//2
}//1