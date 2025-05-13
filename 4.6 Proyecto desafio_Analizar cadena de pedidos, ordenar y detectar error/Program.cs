string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

//troceamos el string
string[] orderSplit = orderStream.Split(',');
//ordenamos el array
Array.Sort(orderSplit);

//recorremos el array
foreach (var orderId in orderSplit)
{
    //comprobamos si el id de la orden tiene 4 caracteres
    //vamos imprimiendo según el resultado controlando con un if/else
    if (orderId.Length == 4)
    {
        Console.WriteLine(orderId + "\t- OK");

    }
    else 
    { 
    Console.WriteLine(orderId + "\t- Error");
    }
}
