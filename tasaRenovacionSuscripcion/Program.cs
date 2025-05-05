Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration > 5)
{
    Console.WriteLine("La suscripción termina pronto. Renuévela ahora. ");
}
else if (daysUntilExpiration > 1)
{
    discountPercentage = 10;
    Console.WriteLine($"La suscripción termina en {daysUntilExpiration} días. \n Renueva ahora y obtén un {discountPercentage}% de descuento");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"La suscripción termina en {daysUntilExpiration} día. \n Renueva ahora y obtén un {discountPercentage}% de descuento");
}
else if (daysUntilExpiration == 0) {
    Console.WriteLine("La suscripción ha expirado");
}