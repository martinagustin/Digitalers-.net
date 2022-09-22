/*
 //     ejercicio 1
Dado el vector {10,20,5,15,30,20}
1. Informar el vector de la forma: "Índice: X,
Valor: Y"
2. Totalizar el vector e informar el total
3. Informar el contenido de las posiciones
impares (por ejemplo, las posiciones 1,3,5,etc)
4. Informar el mayor número
5. Informar cuántas veces aparece el número 20

int[] vector = { 10, 20, 5, 15, 30, 2 };
int n = 0;
int total = 0;
int contador = 0;
int maximo = vector[0];
for (n = 0; n < vector.Length; n++)
{
    if (n % 2 == 1)
    {
        Console.WriteLine($"posicion impar\n {n}={vector[n]}");
    }
    total+=vector[n];
    if(vector[n] > maximo)
    {
        maximo = vector[n];
    }
    if(vector[n] == 20)
    {
        contador++;
    }
}
Console.WriteLine("-------------------");
Console.WriteLine($"el total es: {total}");
Console.WriteLine($"el mayor es: {maximo}");
Console.WriteLine($"el numero 20 aparece {contador} veces");
*/

