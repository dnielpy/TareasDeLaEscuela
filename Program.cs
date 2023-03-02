Console.WriteLine("Ingrese la Hora A: ");
int horaA = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la Minutos A: ");
int minutosA = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la Hora B: ");
int horaB = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la Minutos B: ");
int minutosB = int.Parse(Console.ReadLine());

int hora = horaA + horaB;
int minutos = minutosA + minutosB;

if (minutos > 59)
{
    minutos = minutos - 60;
    hora = hora + 1;
}

if (hora > 23)
{
    hora = hora - 24;
}

Console.WriteLine("La hora es: {0}:{1}", hora, minutos);