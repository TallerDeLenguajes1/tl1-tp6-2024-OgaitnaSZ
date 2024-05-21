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

//Calculadora V1
int num1;
int num2;
int control = 1;
int bandera = 1;
int opc = 0;

do{
    Console.WriteLine("--- CALCULADORA V1 ---");
    Console.WriteLine("1: Sumar");
    Console.WriteLine("2: Restar");
    Console.WriteLine("3: Multiplicar");
    Console.WriteLine("4: Dividir");

    string opcion = Console.ReadLine();

    if(int.TryParse(opcion, out opc)){
        Console.WriteLine("Ingrese dos numeros");
        string buff1= Console.ReadLine();
        string buff2= Console.ReadLine();
        if (int.TryParse(buff1, out num1) && int.TryParse(buff2, out num2)){  //Si son numeros enteros, realiza las operaciones
            switch(opc){
                case 1: 
                        Console.WriteLine("La suma es: "+ (num1+num2));
                        break;
                case 2: 
                        Console.WriteLine("La diferencia del num1 y num2 es: "+ (num1-num2));
                        break;
                case 3: 
                        Console.WriteLine("El producto es: "+ (num1*num2));
                        break;
                case 4: 
                        Console.WriteLine("El cociente es: "+ (num1/num2));
                        break;   
                default:
                        Console.WriteLine("Elija una opcion para operar");
                        break;
            }

            do{ //Control para ingresar un int
                Console.WriteLine("Quiere realizar otra operacion? 1:Si / 0: No");
                string buff3 = Console.ReadLine();
                if(!int.TryParse(buff3, out bandera)){ 
                    Console.WriteLine("Ingrese una opcion valida");
                    control=0;
                }
                else{
                    control=1;
                }
            }while(control==0);
        }
    }
}while(bandera==1);
