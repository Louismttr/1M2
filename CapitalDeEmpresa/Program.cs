// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** CAPITAL DE LA EMPRESA ***");
Console.WriteLine();

//Variables 
double s1, s2, s3, p1, p2, p3, mt;

//datos a solicitar 
Console.Write("Ingrese la cantidad aportada del socio #1: ");
s1 = double.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad aportada del socio #2: ");
s2 = double.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad aportada del socio #3: ");
s3 = double.Parse(Console.ReadLine());

//calculos
mt = s1 + s2 + s3;
p1 = (s1 * 100)/mt;
p2 = (s2 * 100) / mt;
p3 = (s3 * 100) / mt;

//SALIDA
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("EL capital de la empresa es de: " + mt.ToString("0.00"));
Console.WriteLine(" El porcentaje del socio 1 en el capital es del " + p1);
Console.WriteLine(" El porcentaje del socio 2 en el capital es del " + p2);
Console.WriteLine(" El porcentaje del socio 3 en el capital es del " + p3);