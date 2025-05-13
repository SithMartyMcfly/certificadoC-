/*string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));*/

/*string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));*/

Console.WriteLine("*********************");

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";


// Your work here
//en el inicio de la posición debería sumarse la longitud de la cadena "<div>" y <span> para que no la incluya en el resultado
int openingPosition = input.IndexOf("<div>"); //+ "<div>".Length;
int closingPosition = input.IndexOf("</div>");
int openingPosition2 = input.IndexOf("<span>") + "<span>".Length;
int closingPosition2 = input.IndexOf("</span>");
int length2 = closingPosition2 - openingPosition2;
int length = closingPosition - openingPosition;
output = input.Substring(openingPosition, length);
quantity = input.Substring(openingPosition2, length2);

Console.WriteLine(quantity);
Console.WriteLine($"cadena reemplazada {output.Replace("&trade;", "&reg;")}");
