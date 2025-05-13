int first = 2;
string second = "4";

//int result = first + second; No se puede convertir un int a un string
string result = first + second; //Se puede convertir un string a int
Console.WriteLine(result);

Console.WriteLine("//-------------//");
int myInt = 3;
Console.WriteLine($"int:  { myInt }");
decimal myDecimal = myInt;
Console.WriteLine($"decimal:  { myDecimal }");

Console.WriteLine("//-------------//");
decimal otherDecimal = 3.14m;
Console.WriteLine($"decimal: {otherDecimal}");

int otherInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

Console.WriteLine("//-------------//");
decimal thirdDecimal = 1.23456789m;
float myFloat = (float)thirdDecimal;

Console.WriteLine($"Decimal: {thirdDecimal}");
Console.WriteLine($"Float  : {myFloat}");

Console.WriteLine("//-------------//");//al sumar dos strings se concatenan
int firstNumber = 5;
int secondNumber = 7;
string message = firstNumber.ToString() + secondNumber.ToString();
Console.WriteLine(message);

Console.WriteLine("//-------------//");//parseamos a int y despues sumamos lo que antes eran strings
string otherfirst = "5";
string othersecond = "7";
int sum = int.Parse(otherfirst) + int.Parse(othersecond);
Console.WriteLine(sum);

Console.WriteLine("//-------------//");
string value1 = "5";
string value2 = "7";
int otherresult = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(otherresult);

Console.WriteLine("//-------------//");
int othervalue = (int)1.5m; // casting trunca
Console.WriteLine(othervalue);

int othervalue2 = Convert.ToInt32(1.5m); // converting redondea
Console.WriteLine(othervalue2);

Console.WriteLine("//-------------//"); //uso método TryParse, usa variable auxiliar
string value = "102";
int myresult = 0;
if (int.TryParse(value, out myresult))
{
    Console.WriteLine($"Measurement: {myresult}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

//comprobación que no se puede usar tryparse con un string que no es un número.
Console.WriteLine("//-------------//");
string thisValue = "bad";
int thisResult = 0;
if (int.TryParse(thisValue, out thisResult))
{
    Console.WriteLine($"Measurement: {thisResult}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (thisResult > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + thisResult}");




