using System;
int a = int.Parse(Console.ReadLine());
string op = Console.ReadLine();
int b = int.Parse(Console.ReadLine());

Console.WriteLine(MathOperations(a,op,b));



static double MathOperations(int a, string op, int b){
    double result =0;
    switch(op){
     case "*":
     result=a*b;
     break;
     case "/":
     result=a/b;
     break;
     case "+":
     result=a+b;
     break;
     case "-":
     result=a-b;
     break;
    }
    return result;
}