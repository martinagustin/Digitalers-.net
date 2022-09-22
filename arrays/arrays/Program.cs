//ArrayDinamico();
//ArrayDinamicoAleatorio();
//EjercicioArrayMaxMin();
//contarNumero();
//contarPares();
juntarArrays();
static void ArrayDinamico()
{
    Console.WriteLine("Ingrese cantidad de numeros del array");
    int cantidad = Convert.ToInt32(Console.ReadLine());
    double[] numeros = new double[cantidad];
    double suma = 0;
    double producto = 1;
    int a = 0;
    Console.WriteLine("ingrese los numero enteros");
    while(a< numeros.Length)
    {
        numeros[a] = Convert.ToDouble(Console.ReadLine());
        a++;
    }
    foreach(double d in numeros)
    {
        suma +=d;
        producto *= d;
    }
    Console.WriteLine("Producto de los numeros = {0}",producto);
    Console.WriteLine("Cantidad de productos = {0}",numeros.Length);
    Console.WriteLine("suma total = {0}",suma);
}
static void ArrayDinamicoAleatorio()
{
    Console.WriteLine("Ingrese cantidad de numeros del array");
    int cantidad = Convert.ToInt32(Console.ReadLine());
    double[] numeros = new double[cantidad];
    double suma = 0;
    double producto = 1;
    int a = 0;
    Random b = new Random();
    Console.WriteLine("Numeros ingresados de manera automatica");
    while (a < numeros.Length)
    {
        numeros[a] = b.Next(0,100);
        //numeros[a] = b.Next(0,2);

        a++;
    }
    
    foreach (double d in numeros)
    {
        Console.WriteLine(d);
        suma += d;
        producto *= d;
    }
    Console.WriteLine("Producto de los numeros = {0}", producto);
    Console.WriteLine("Cantidad de productos = {0}", numeros.Length);
    Console.WriteLine("suma total = {0}", suma);

}
static void EjercicioArrayMaxMin()
{
    Console.WriteLine("Ingrese cantidad de numeros del array");
    int cantidad = Convert.ToInt32(Console.ReadLine());
    double[] numeros = new double[cantidad];
    Random b = new Random();
    Console.WriteLine("ingrese numero repetido a buscar");
    double numero_repetido = 0;
    for(int i = 0; i < numeros.Length; i++){
        numeros[i] = b.Next(0,100);
    }
    Array.Sort(numeros);
    Console.WriteLine("Numeros del array");
    foreach (double d in numeros)
    {
        Console.WriteLine(d);
    }
    double minimo = numeros[0], maximo = numeros[0];

    for (int j = 0; j < numeros.Length; j++)
    {
        if(numeros[j] > maximo)
        {
            maximo = numeros[j];
        }
        if (numeros[j] < minimo)
        {
            minimo = numeros[j];
        }
    }
    double repeticiones = 0;
    for(int i=0; i < numeros.Length; i++)
    {
        if (repeticiones == numeros[i])
        {
            repeticiones++;
        }
    }
    Console.WriteLine("Cantidad de productos = {0}", numeros.Length);
    Console.WriteLine("Maximo = {0}",maximo);
    Console.WriteLine("Minimo = {0}",minimo);

}
static void contarNumero()
{
    Console.WriteLine("Ingrese cantidad de numeros del array");
    int cantidad = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("ingrese numero repetido a buscar");
    double numero_repetido = Convert.ToDouble(Console.ReadLine());
    
    double[] numeros = new double[cantidad];
    
    Random b = new Random();
    
    for (int i = 0; i < numeros.Length; i++)
    {
        numeros[i] = b.Next(0, 100);
    }
    Array.Sort(numeros);
    Console.WriteLine("Numeros del array");
    foreach (double d in numeros)
    {
        Console.WriteLine(d);
    }

    double repeticiones = 0;
    for (int i = 0; i < numeros.Length; i++)
    {
        if (repeticiones == numeros[i])
        {
            repeticiones++;
        }
    }
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine("el numero {0} se repite {1} veces",numero_repetido,repeticiones);

}
static void contarPares()
{
    Console.WriteLine("Ingrese cantidad de numeros del array");
    int cantidad = Convert.ToInt32(Console.ReadLine());

    int[] numeros = new int[cantidad];
    int[] numeros_pares = new int[cantidad];

    Random b = new Random();

    for (int i = 0; i < numeros.Length; i++)
    {
        numeros[i] = b.Next(0, 100);
    }

    int pares = 0;
    int x = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
        {
        if (numeros[i] %2 ==0)
                numeros_pares[x] = numeros[i];
                x++;
                pares++;
        }
    }
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine("Cantidad de numeros pares = {0}",pares);
    Console.WriteLine("Elementos del vector");
    foreach(int elemento in numeros_pares)
    {
        Console.WriteLine(elemento);
    }
}
static void juntarArrays()
{
    //declaramos objeto random
    Random b = new Random();

    //primer array
    Console.WriteLine("Ingrese cantidad de numeros del 1er array");
    int cantidad = Convert.ToInt32(Console.ReadLine());

    int[] numeros = new int[cantidad];
    int[] numeros_pares = new int[cantidad];

    for (int i = 0; i < numeros.Length; i++)
    {
        numeros[i] = b.Next(0, 100);
    }
    Console.WriteLine(Environment.NewLine + "Numeros del 1er Array " + Environment.NewLine);
    foreach (int item in numeros)
    {
        Console.WriteLine(item);
    }
    //array 2
    Console.WriteLine("Ingrese cantidad de numeros del 2do array");
    cantidad = Convert.ToInt32(Console.ReadLine());
    int[] numeros2 = new int[cantidad];
    for (int i = 0; i < numeros2.Length; i++)
    {
        numeros2[i] = b.Next(0, 100);
    }
    Console.WriteLine(Environment.NewLine + "Numeros del 2do Array " + Environment.NewLine);
    foreach (int item in numeros)
    {
        Console.WriteLine(item);
    }
    //3er array
    int[] array_resultado = new int[numeros.Length + numeros2.Length];
    for (int i = 0; i < numeros.Length; i++)
    {
        array_resultado[i] = numeros[i];
    }
    for (int i = 0; i < numeros2.Length; i++)
    {
        array_resultado[numeros.Length + 1] = numeros2[i];
    }
    Console.WriteLine("array resultado");
    foreach(int item in array_resultado)
    {
        Console.WriteLine(item);
    }
}

