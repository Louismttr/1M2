// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Control de ventas ***");
Console.WriteLine();

//Declaraciones 
double ic, id, ipp;
int can;

//Entrada
Console.WriteLine("Ingrese el valor del producto: ");
ic = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de unidades a comprar: ");
can = int.Parse(Console.ReadLine());

//Operación
id = ic * 0.11;
ipp = ic - id;

//Salida
Console.WriteLine("°'''''''''''''''''''''''''''''''''''''''''''''''''''''°");
Console.WriteLine("El importe total a pagar es de: " + ipp.ToString("0.00"));
Console.WriteLine("El importe con descuento es de: " + ic.ToString("0.00"));