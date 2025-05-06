
string[] idDelibery = {
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};
Console.WriteLine("Los pedidos que deben revisarse son:");
foreach (string id in idDelibery) {
    if (id.StartsWith("B")) {
        Console.WriteLine(id);    
    }
}
