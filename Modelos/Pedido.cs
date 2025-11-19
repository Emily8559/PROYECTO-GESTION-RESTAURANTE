        private static int contador = 1;
        public int NumeroPedido { get; private set; }
        public Listaenlazada<PlatoPedido> Platos { get; set; }
        public void CalcularTotal()
        {
            Total = 0;
            Platos.Recorrer(SumarSubtotal);

            }

        private void SumarSubtotal(PlatoPedido plato)
        {
            Total += plato.Subtotal;
        }
