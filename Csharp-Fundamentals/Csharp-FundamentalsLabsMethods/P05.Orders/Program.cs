﻿string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

orderPrice(product,quantity);

static void orderPrice(string product,int quantity)
{
double sum = 0;
switch(product){
    case "coffee":
 sum += quantity * 1.50;
    break;
    case"water":
sum += quantity *1.00; 
    break;
    case"snacks":
sum+= quantity *2.00;
    break;
    case"coke":
sum+= quantity *1.40;
    break;
}
Console.WriteLine($"{sum:f2}");
}