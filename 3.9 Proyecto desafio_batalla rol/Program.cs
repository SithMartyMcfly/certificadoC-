int playerLife = 20;
int monsterLife = 20;

Random attack = new Random();

do
{
    int playerAttack = 0;
    playerAttack = attack.Next(1, 11);
    monsterLife = monsterLife - playerAttack;
    Console.WriteLine($"Monster was damage and lost **{playerAttack}** health,-- ({monsterLife}) -- health remaining");

    if (monsterLife > 0)
    {
        int monsterAttack = 0;
        monsterAttack = attack.Next(1, 11);
        playerLife = playerLife - monsterAttack;
        Console.WriteLine($"--Hero was damage and lost **{monsterAttack}** health,-- ({monsterLife}) -- health remaining");
    }
    else
    {
        break;
    }

} while (playerLife > 0 && monsterLife > 0);

if (playerLife > 0)
{
    Console.WriteLine("Hero wins!");
}
else
{
    Console.WriteLine("Monster wins!");
}
