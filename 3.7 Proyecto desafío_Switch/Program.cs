// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "02-MN-M";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}
switch (product[0]) {
    case "01":
        type = "Sweat shirt";
    break;    
    case "02":
        type = "T-shirt";
    break;    
    case "03":
        type = "Sweat pants";
    break;
    default:
        type = "Other ";
        break;
}
switch (product[1]) {
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";   
         break;
}

switch (product[2]) {
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size="One Size Fits All";
        break;
}


Console.WriteLine($"Product: {size} {color} {type}");