string[] values = { "12,3", "45", "ABC", "11", "DEF" };

string cadena = "";
decimal resultado = 0m;

/*foreach(var value in values) usar var cuando las variables cambiarán de tipo*/ 
for (int i = 0; i <values.Length;  i++) {
    decimal numero;//variable auxiliar para el método TryParse
    if (decimal.TryParse(values[i], out numero))//tengo que operar con la variable devuelta en TryParse
    {
        resultado += numero;
    }
    else
    { //si no es número, lo concateno
        cadena += values[i];
    }
}

Console.WriteLine($"La suma de los números es: {resultado}");
Console.WriteLine($"La concatenación de los textos es: {cadena}");