///<summary>
///
/// Alumno: Hiram Alejandro Ramírez González    Matricula: 1733751  Materia: Lab. Sistemas Distribuidos y Paralelos AGO-DIC 22 (NO ESCOLARIZADA)
/// Actividad 4: Dependencia
/// Ejemplo de Dependencia de Control
///  
/// </summary>

string r;
int correcto =0, incorrecto=0, resp;

Console.WriteLine("Concurso para ganar");
Console.WriteLine("Elige una materia");
Console.WriteLine("1.- Geografia   2.- Matematicas    3.- Biologia");
r = Console.ReadLine();
resp = int.Parse(r);
switch (resp) {
    case 1:
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("¿Cuál es la capital de México?");
        Console.WriteLine("1.- CDMX  2.- Cd. de México  3.- Nuevo Léon  4.- Guatemala");
        r = Console.ReadLine();
        resp = int.Parse(r);
        if (resp == 1)
        {
            correcto++;
            Console.WriteLine($"Tu marcador es:\n Respuestas correctas: {correcto}\nRespuestas incorrectas: {incorrecto}");
        }
        else
        {
            incorrecto++;
            Console.WriteLine($"Tu marcador es:\n Respuestas correctas: {correcto}\nRespuestas incorrectas: {incorrecto}");
        }
        break;

    case 2:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Formula del teorema de Pitagoras");
        Console.WriteLine("1.- c2 = a2 + b2    2.- π x r2      3.- F = ma       4.- (vf – vi)/(tf – ti)");
        r = Console.ReadLine();
        resp = int.Parse(r);
        if (resp == 1)
        {
            correcto++;
            Console.WriteLine($"Tu marcador es:\n Respuestas correctas: {correcto}\nRespuestas incorrectas: {incorrecto}");
        }
        else
        {
            incorrecto++;
            Console.WriteLine($"Tu marcador es:\n Respuestas correctas: {correcto}\nRespuestas incorrectas: {incorrecto}");
        }
        break;
    case 3:
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("¿Cuántos huesos hay en el cuerpo humano?");
        Console.WriteLine("1.- 132    2.- 206    3.- 208    4.- 200");
        r = Console.ReadLine();
        resp = int.Parse(r);
        if (resp == 2)
        {
            correcto++;
            Console.WriteLine($"Tu marcador es:\n Respuestas correctas: {correcto}\nRespuestas incorrectas: {incorrecto}");
        }
        else
        {
            incorrecto++;
            Console.WriteLine($"Tu marcador es:\n Respuestas correctas: {correcto}\nRespuestas incorrectas: {incorrecto}");
        }
        break;

}
Console.Clear();
resp = 0;
Console.WriteLine("Elige una materia");
Console.WriteLine("1.- Literatura   2.- Geografia   3.- Biologia");
r = Console.ReadLine();
resp = int.Parse(r);
switch (resp)
{
    case 1:
        Console.Clear();
        Console.WriteLine("¿Cuál es el libro más vendido de la historia?");
        Console.WriteLine("1.- Don Quijote de la Mancha     2.- La Divina Comedia    3.- El cantar del Mio Sid     4.- La Biblia");
        r = Console.ReadLine();
        resp = int.Parse(r);
        if(resp == 4){
            correcto++;
            Console.WriteLine($"Tu marcador es:\n Respuestas correctas: {correcto}\nRespuestas incorrectas: {incorrecto}");
        }
        else
        {
            incorrecto++;
            Console.WriteLine($"Tu marcador es:\n Respuestas correctas: {correcto}\nRespuestas incorrectas: {incorrecto}");
        }
        break;
    case 2:
        Console.WriteLine("¿Cuál es el océano más grande del mundo?");
        Console.WriteLine("1.- El océano Atlantico   2.- El océano Indigo   3.- El océano Pacífico    4.- El océano de las Malvinas");
        r = Console.ReadLine();
        resp= int.Parse(r);
        if (resp == 3)
        {
            correcto++;
            Console.WriteLine($"Tu marcador es:\n Respuestas correctas: {correcto}\nRespuestas incorrectas: {incorrecto}");
        }
        else
        {
            incorrecto++;
            Console.WriteLine($"Tu marcador es:\n Respuestas correctas: {correcto}\nRespuestas incorrectas: {incorrecto}");
        }
        break;
    case 3:

        break;
}




