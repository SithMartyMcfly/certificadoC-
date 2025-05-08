
string entrada = "";
int numero;

Console.WriteLine("Please enter an integer between 5 and 10");
do
{
    entrada = Console.ReadLine();
    //guardamos en variable booleana si es un numero y devolvemos en variable
    bool esNumero = int.TryParse(entrada, out numero);
    //procesamos según si el parseo ha sido true o false
    if (esNumero)
    {
        Console.Write("You entered " + numero + ". ");
        if (numero > 10 || numero < 5) {
            Console.WriteLine("Please enter a number between 5 and 10");
        }
    }
    else {
        Console.WriteLine(entrada + " is an invalid enter");
    }
    
    
}
while (numero>10 || numero<5);

Console.WriteLine("Has been accepted");

Console.WriteLine();
Console.WriteLine("***************-----------------******************");
Console.WriteLine(); 
Console.WriteLine("Enter your role name (Administrator, Manager or User)");

string? role = "";

do
{
    role = Console.ReadLine();
    role.Trim().ToLower();
    if (!role.Equals("administrator") && !role.Equals("manager") && !role.Equals("user"))
    {
        Console.WriteLine($"The role name that you entered, \"{role}\" is not valid");
    }
    else {
        Console.WriteLine($"Your input value {role} has been accepted.");
    }
}
while (!role.Equals("administrator") && !role.Equals("manager") && !role.Equals("user"));

Console.WriteLine();
Console.WriteLine("***************-----------------******************");
Console.WriteLine();

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", 
                                    "I like all three of the menu choices" };

int periodLocation = 0;
string myString="";
string caracter = "";
for (int i = 0; i < myStrings.Length; i++) {
    myString = myStrings[i];
    periodLocation = myString.IndexOf('.');

    string phrase;

    while (periodLocation != -1) {

        phrase = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation + 1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(phrase);
    }

    phrase = myString.Trim();
    Console.WriteLine(phrase);
       
}
