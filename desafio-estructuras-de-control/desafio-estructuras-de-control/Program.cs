/*
 //             ejercicio n1
 //Una persona desea invertir $1000 en un banco, el
cual le otorga un 2% de interés mensual.
¿Cuál será la cantidad de dinero que esta
persona tendrá al cabo de un año?.
 * int mes = 1;
double dinero = 1000;
while (mes <= 12)
{
    dinero *= 1.02;
    mes++;
    Console.WriteLine($"dinero en el mes {mes-1} es ={dinero}");
}
Console.WriteLine("----------------------");
Console.WriteLine($"total acumulado final ={dinero}");
*/

/*
 //         ejercicio 2
Una persona desea invertir $1000 en un banco, el
cual le otorga un 3% de interés mensual.
 
int mes = 1;
double dinero = 1000;
while (mes <= 12)
{
    dinero *= 1.03;
    mes++;
    Console.WriteLine($"dinero en el mes {mes - 1} es ={dinero}");
    if (dinero >= 1200)
    {
        break;
    }
}
Console.WriteLine("----------------------");
Console.WriteLine($"haz obtenido :{dinero}$ en {mes-1} meses");
*/

/*
 //     ejercicio 3
Desarrollar el código que permita a una persona
ingresar como máximo tres veces su contraseña.
ingreso correcto deberá exhibirse
la leyenda “Bienvenido!!”, caso contrario se
mostrará “tres veces fallidas”
Indicar cuantas posibilidades de ingresar el
código le queda

int intentos = 0;
string contrasena = "";

while (intentos < 3)
{
    Console.WriteLine("Ingrese su contrasenia");
    contrasena=Console.ReadLine();
    if(contrasena == "1234")
    {
        Console.WriteLine("bienvenido");
        break;
    }
    else if (intentos == 1)
    {
        Console.WriteLine("Atención!! Ultima oportunidad!");
    }
    intentos++;
    Console.WriteLine($"le quedan {3-intentos} intentos");
}
Console.WriteLine("fin");
*/
