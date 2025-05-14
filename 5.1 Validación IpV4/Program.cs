string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };

bool validFormat = false;
bool validNumber = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    validateFormat(ip);
    validateNumber(ip);
    validateRange(ip);
    if (validFormat && validNumber && validRange) { 
    Console.WriteLine($"The IP address {ip} is VALID.");
    }
    else
    {
        Console.WriteLine($"The IP address {ip} is INVALID.");
    }   
 
}

void validateFormat(string ip) {
    string[] numberTrios = ip.Split(".");
    if (numberTrios.Length == 4) {
        validFormat = true;
    }
    else
    {
        validFormat = false;
    }
}

void validateNumber (string ip)
{

    string[] numberTrios = ip.Split(".");
    foreach (string number in numberTrios)
    {
        if (!number.StartsWith("0"))
        {
            validNumber = true;
        }
        else
        {
            validNumber  = false;
        }
    }
}

void validateRange(string ip)
{
    string[] numberTrios = ip.Split(".");
    foreach (string number in numberTrios)
    {
        if (!string.IsNullOrEmpty(number) && int.TryParse(number, out int trio))
        {
            if (trio >= 0 && trio <= 255)
            {
                validRange = true;
            }
            else
            {
                validRange = false;                
            }
        }
        else
        {
            validRange = false;
        }
    }
}
