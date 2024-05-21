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

//Calculadora V2
Console.WriteLine("Ingrese un numero:");
string buff1= Console.ReadLine();
if (int.TryParse(buff1, out num1)){
    //Valor Absoluto
    double valorAbsoluto = Math.Abs(num1);
    Console.WriteLine("Valor absoluto: "+valorAbsoluto);

    // Cuadrado
    double cuadrado = Math.Pow(num1, 2);
    Console.WriteLine("Cuadrado: " +cuadrado);

    // Raíz cuadrada
    if (num1 >= 0){
        double raiz = Math.Sqrt(num1);
        Console.WriteLine("Raiz cuadrada: "+raiz);
    }else{
        Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
    }

    // Seno
    double seno = Math.Sin(num1);
    Console.WriteLine("Seno: "+seno);

    // Coseno
    double coseno = Math.Cos(num1);
    Console.WriteLine("Coseno: "+ coseno);

    // Parte entera de un tipo float
        int integerPart = (int)num1;
        Console.WriteLine($"Parte entera: "+integerPart);

}