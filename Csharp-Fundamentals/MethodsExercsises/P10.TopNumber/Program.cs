int endNumber = int.Parse(Console.ReadLine());

for (int i = 1; i<=endNumber; i ++ ){
    
    if (isTopNumber(i)){
        Console.WriteLine(i);
    }
}

static bool isTopNumber(int num){

   if(isDivisibleByEight(num) && hasOddNumber(num)){
    return true;
   }

return false;
}

static bool isDivisibleByEight(int num){
int sum = 0;
while(num >0){

var digit = num% 10;
sum += digit;
num /= 10;
}

return sum % 8 == 0;
}

static bool hasOddNumber(int num){
    
    while (num>0){

     var digit = num%10;
     if(digit % 2 != 0){

         return true;
     }
     num /= 10;
    }
    
    return false;
}
