using System.Collections;

namespace PRestaurante.Modelos
{//1
    public class PlatoPedido
    {//2
    public string CodigoPlato { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioIndividual { get; set; }

    public decimal Subtotal
        {
            get { return Cantidad * PrecioIndividual; }
        }


    public PlatoPedido(string codigoplato, int cantidad, decimal precioindividual)
    {//3
        CodigoPlato = codigoplato; 
        Cantidad = cantidad;
        PrecioIndividual = precioindividual;


    }//3
    public override string ToString()
        {
            return $"{CodigoPlato} x {Cantidad} = ${Subtotal}";
        }

    }//2
}//1