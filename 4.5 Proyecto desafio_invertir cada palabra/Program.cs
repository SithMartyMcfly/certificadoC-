string pangram = "The quick brown fox jumps over the lazy dog";
//dividimos la cadena y la almacenamos en un array
string[] words = pangram.Split(' ');


foreach (string palabra in words) {
    //troceamos la palabra
    char[] nuevoArray = palabra.ToCharArray();
    //invertimos el array (es la palabra suelta)
    Array.Reverse(nuevoArray);
    //concatenamos el array invertido en una cadena
    string palabraReverse = string.Concat(nuevoArray);
    //formateamos la cadena con un espacio entre palabras
    Console.Write(palabraReverse + " ");
}



