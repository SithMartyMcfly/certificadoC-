namespace certificado
{
    internal class RandomDice
    {
        private static void Main(string[] args)
        {
            Random dice = new Random();
            int roll = dice.Next(1, 6);

            Console.WriteLine(roll);
        }
    }
}