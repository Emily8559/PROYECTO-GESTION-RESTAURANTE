        private Listaenlazada<Pedido> pedidos = new Listaenlazada<Pedido>();
        private decimal gananciasDia = 0;
        public void ListarClientes()
        {//6
            if (precio <= 0)
            {
                Console.WriteLine("El precio tiene que ser mayor a cero");
                return;
            }
            bool existe = false;
            menu.Recorrer(p =>
            {
                if (p.Codigo == codigo) existe = true;
            });
            if (existe)
            {
                Console.WriteLine("Ya existe un plato con ese código");
                return;
            }
            menu.Insertar(new Plato(codigo, nombre, descripcion, precio));
            Console.WriteLine("Plato agregado al menú correctamente");
        public void TomarPedido(string cedulacliente)
