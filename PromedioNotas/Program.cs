// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** PROMEDIO DE NOTAS ***");
Console.WriteLine("");

double nota1, nota2, nota3, promedio;
string alumno;

Console.WriteLine("Ingrese el nombre del Estudiante ");
alumno = Console.ReadLine();

Console.WriteLine("Ingrese la nota 1 del estudiante " + alumno);
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la nota 2 del estudiante " + alumno);
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la nota 3 del estudiante " + alumno);
nota3 = double.Parse(Console.ReadLine());

promedio = (nota1 + nota2 + nota3)/3;

Console.WriteLine("--------------------------------------------------------------------------------");
Console.WriteLine("El promdio del estudiante " + alumno + " es de: " + promedio.ToString("0.00"));
