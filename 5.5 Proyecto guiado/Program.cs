using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

RandomizeAnimals();
string [,] group = AssignGroup();

PlanSchoolVisit("A");
PlanSchoolVisit("B", 3);
PlanSchoolVisit("C", 2);


void RandomizeAnimals () {
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) {     
    int r = random.Next(i, pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
    }
}

//se le añade un valor por defecto, es decir si no se pasan parámetros, asigna por defecto 6
string[,] AssignGroup (int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];

    int start = 0;
    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }
    return result;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++) {
        Console.WriteLine($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++) { 
        Console.Write($"{group[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PlanSchoolVisit (string schoolName, int groups = 6) { 
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine($"{schoolName} has {groups} groups.");
    PrintGroup(group);
}