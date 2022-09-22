/*laboratorio 1
 * 
 * Console.WriteLine("Hello, World!");
string simbolo = "@";
for(int i = 5; i >-1 ; i--)
{
    if(i == 0 || i == 5)
    {
        Console.WriteLine("@@@@@");
    }
    else if(i ==1 || i == 4)
    {
        Console.WriteLine("@@@");
    }
    else
    {
        Console.WriteLine("@");
    }
}

//ejercicio 2
int a=1;
int suma =0;

while (a < 21)
{
    if(a%2==0 && a < 20 && a>9){
        suma+=a;
        a++;
    }
    else
    {
        a++;
    }
}
Console.WriteLine(suma) ;
*/

//ejercicio 3
int i = 0, numero = 0, menor = 0,mayor = 0;
do
{
    Console.WriteLine("Ingrese numero:");
    numero= Convert.ToInt32(Console.ReadLine());
    i++;
    mayor = numero;
    menor = numero;
}
while (i < 5);

{
    if (numero < menor)
    {
        menor = numero;
        
    }
    else 
    {
        mayor = numero;
    }
}
Console.WriteLine($"mayor:{menor}\tmenor:{menor}");