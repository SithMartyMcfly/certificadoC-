string[] names = { "Antonio", "Cristina", "Roberto" };
Console.WriteLine("-----------------");
foreach (string name in names) { 
    Console.WriteLine(name);
}

int[] inventory = {200, 450, 700, 175, 250 };
Console.WriteLine("-----------------");
foreach (int item in inventory) {
    Console.WriteLine(item);
}

int sum = 0;
Console.WriteLine("-----------------");
foreach (int item in inventory) {
    sum += item;
}
Console.WriteLine("tenemos un total de " + sum);

int bin = 0;
sum = 0;
Console.WriteLine("-----------------");
    foreach (int item in inventory) {
    sum += item;
    bin++;
    Console.WriteLine($"contenedor {bin} tiene {item} (Actualmente con un total de = {sum})");
}
Console.WriteLine("-----------------");