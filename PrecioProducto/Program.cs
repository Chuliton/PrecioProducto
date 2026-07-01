namespace PrecioProducto
{
    /*Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar
     (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de 
    cuenta (inventado)*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el precio del producto");
            int precio = 0;
            while (precio <= 0) {
                precio = int.Parse(Console.ReadLine());
                if (precio <= 0)
                Console.WriteLine("El precio de debe ser mayor a 0");
            }
            Console.WriteLine("Ingrese el medio de pago (Efectivo o Tarjeta)");
            string formaPago = Console.ReadLine().ToLower();
            if (formaPago == "tarjeta")
            {
                Console.WriteLine("Ingrese el numero de cuenta");
                int numCuenta = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Transaccion exitosa");
        }
    }
}
