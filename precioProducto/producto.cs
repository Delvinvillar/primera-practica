using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace precioProducto
{
    internal class producto
    {
        public void precio()
        {
            decimal precio = 0;
            int cantidad = 0;
            decimal total = 0;

            try
            {
                Console.WriteLine("ingrese el precio del articulo");
                precio = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("ingre la cantidad que lleva el cliente ");
                cantidad = Convert.ToInt32(Console.ReadLine());

                total = precio * cantidad;
                Console.WriteLine($"el total abonar es:{total} ");

            }
            catch (OverflowException)
            {
                Console.WriteLine(" el numero es demaciado grande ");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio un error :{ex.Message}");
            }
        }
    }
}
