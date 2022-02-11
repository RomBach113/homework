void Pause(string massege="Press any kay")//описание подпрограммы (метода)
{
    System.Console.WriteLine(massege);
    Console.ReadKey();
}

int Sum(int a, int b)
{   
    return a+b;
}

//  void OddOrEven(int a)
// {
//     if(a%2==0) System.Console.WriteLine("Число четное");
//     else System.Console.WriteLine("Число не четное");
// }

bool OddOrEven(int a)
{
    return a%2==0;
    //if(a%2==0) return true; else return false;
}

OddOrEven(5);
if(OddOrEven(5)) System.Console.WriteLine("Число четное");
else System.Console.WriteLine("Число не четное");
Pause();//вызов
Sum(3,3);
int s=Sum(2,2);

System.Console.WriteLine(Sum(2,2));
System.Console.WriteLine(s);