        public string Nit { get; set; }
        public Restaurante(string nombre, string nit, string dueno, string direccion, string celular)
        public override string ToString()
            return $"Restaurante: {Nombre}, NIT: {Nit}, Dueño: {Dueno}, Dirección: {Direccion}, Celular: {Celular}";
