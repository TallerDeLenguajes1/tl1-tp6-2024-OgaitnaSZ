Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);


//Ejercicio 1
Console.WriteLine("Ingrese un numero:");
string entrada = Console.ReadLine(); 
bool entradaNum = int.TryParse(entrada, out int num);

if (entradaNum){
    int invertido = 0;
    while (num > 0){
        int dig = num % 10;
        invertido = (invertido * 10) + dig;
        num = num / 10;
    }
    Console.WriteLine("El numero invertido es:" + invertido);
}