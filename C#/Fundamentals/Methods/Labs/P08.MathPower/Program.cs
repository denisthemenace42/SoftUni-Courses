
double n1 = double.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine(MathPower(n1,n2));



static double MathPower(double n1,int n2){
double result = 1d;
for (int i=0; i<n2;i++){
    result = result * n1;
}
return result;
}
