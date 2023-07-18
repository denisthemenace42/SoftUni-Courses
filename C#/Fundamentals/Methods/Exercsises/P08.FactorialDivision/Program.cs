int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"{FactorialDivision(firstNumber,secondNumber):f2}");

static double FactorialDivision(int firstNumber, int secondNumber){
    double firstFactorial = 1;
    double secondFactorial = 1;
    
        for (int i = 1; i<=firstNumber;i++){

            firstFactorial = firstFactorial*i;
        }
        for (int i = 1; i<=secondNumber;i++){

            secondFactorial = secondFactorial*i;
        }
        double division = firstFactorial / secondFactorial;
    return division;
}
