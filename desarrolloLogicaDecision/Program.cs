Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"El valor de la tirada {roll1} + {roll2} + {roll3} = {total} ");

if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1) {
    Console.WriteLine("Has obtenido un doble sumas 2 a la puntuación");
    total = total + 2;
}

if (roll1 == roll2 && roll2 == roll3) {
    Console.WriteLine("Has obtenido un triple sumas 6 a tu puntuación");
    total = total + 6;
}



if (total >= 16)
{
    Console.WriteLine($"Has obtenido {total} has ganado un coche");
}
else if (total >= 10)
{
    Console.WriteLine($"Has obtenido {total} has ganado un portátil nuevo");
}
else if (total == 7)
{
    Console.WriteLine($"Has obtenido {total} has ganado un viaje");
}
else {
    Console.WriteLine($"Has obtenido {total} has ganado un gatito");
}