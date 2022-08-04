// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** CALCULADPRA DE MONTOS ****");
Console.WriteLine(" ");

double Precio, monto;
int cantidad;

Console.WriteLine("Ingrese el precio del producto C$");
Precio = double.Parse(Console.ReadLine());

Console.WriteLine("ingrese la cantidad seleccionada: ");
cantidad = int.Parse(Console.ReadLine());

monto = Precio * cantidad;

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("El monto total a pagar es de: " + monto.ToString("0.00"));

