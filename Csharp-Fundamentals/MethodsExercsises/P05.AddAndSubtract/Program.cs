int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int result = SumOfTwo(firstNumber,secondNumber);
Console.WriteLine(SubtractThird(result,thirdNumber));

static int SumOfTwo(int firstNumber, int secondNumber){
    int sum = firstNumber+secondNumber;
    return sum;
}

static int SubtractThird(int thirdNumber, int result){
    
    int endSum = thirdNumber-result;
    return endSum; 
}