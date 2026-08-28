Console.WriteLine("EJERCICIO_1");                                    //#1
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");    //Promedio en 3 calificaciones
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola

Console.Write("Ingrese la primera calificación: ");
double calificacion1 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 1

Console.Write("Ingrese la segunda calificación: ");
double calificacion2 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 2

Console.Write("Ingrese la tercera calificación: ");
double calificacion3 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 3 

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0;  // se toma en cuenta la suma con la division de ellas para determinar el promedio de las tres calificaciones

Console.WriteLine();
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}");  //se imprime el promedio en la consola, con dos decimales de precisión