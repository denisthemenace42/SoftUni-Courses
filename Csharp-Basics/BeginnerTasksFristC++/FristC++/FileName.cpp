#include<iostream>

int multiplyNumbers(int one, int two)
{
    int result = one * two;
    return result;
}
int divideNumbers(int first, int second)
{
    int result = first / second;
    return result;
}
int main() {

    std::cout <<"Yes" << std::endl;
    std::cout << "Number 2" << std::endl;

    int firstNumber{ 3 };
    int secondNumber{ 5 };

    int sum = firstNumber * secondNumber;

    std::cout << sum << std::endl;

    sum = divideNumbers(50, 5);
        std::cout << sum << std::endl;
        std::cout << divideNumbers(100, 4);
        std::cout << multiplyNumbers(500, 500);
    return 0;
}