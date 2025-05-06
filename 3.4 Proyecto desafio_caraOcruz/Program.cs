Random coin = new Random();

int result = coin.Next(2);
Console.WriteLine(result>0 ? "HEAD" : "TAILS");

//otra solución
/*string coinResult(int result) => result > 0 ? "HEAD" : "TAILS"; 
Console.WriteLine(coinResult(result));*/


