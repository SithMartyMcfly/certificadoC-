string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
}

doMail(corporate);
doMail(external);

void doMail(string[, ] employes ) {
    string email = "";
    for (int i = 0; i < employes.GetLength(0); i++)
    {
        string firstName = employes[i, 0];
        string lastName = employes[i, 1];
        if (employes == corporate) { 
            email = $"{firstName.Substring(0, 2).ToLower()}{lastName.ToLower()}@contoso.com";
        }
        else
        {
            email = $"{firstName.Substring(0, 2).ToLower()}{lastName.ToLower()}@{externalDomain}";
        }
        Console.WriteLine(email);
    }
}