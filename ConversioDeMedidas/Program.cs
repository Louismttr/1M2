// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** COVERSION DE MEDIDAS ***");
Console.WriteLine("");

//Variable unica
double metros;

//Variables a dar
double cm, pies, yardas, pulgadas;

//Insertar datos
Console.Write("Ingrese los metros solicitados: ");
metros = double.Parse(Console.ReadLine());

//convertdior
cm = metros * 100;
pulgadas = cm / 2.54;
pies = pulgadas / 12;
yardas = pies / 3;

//Salida
Console.WriteLine("------------------------------------------------------------------------");
Console.WriteLine("El valor convertido en centimetros es de: "+ cm.ToString("0.00"));
Console.WriteLine("El valor convertido en pulgadas es de: " + pulgadas.ToString("0.00"));
Console.WriteLine("El valor convertido en pies es de: " + pies.ToString("0.00"));
Console.WriteLine("El valor convertido en yardas es de: " + yardas.ToString("0.00"));

