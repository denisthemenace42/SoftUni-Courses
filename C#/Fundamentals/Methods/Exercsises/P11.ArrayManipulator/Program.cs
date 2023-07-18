
int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

string input;

while((input = Console.ReadLine()) != "end"){

    string[] inputArguments = input.Split();

    switch(inputArguments[0]){
     
     case "exchange":
     int index = int.Parse(inputArguments[1]);
     numbers = ExchangeElements(numbers,index);
     break;
     case "max":
     string maxType = inputArguments[1];
     PrintMaxIndex(numbers,maxType);
     break;
     case "min":
     string minType = inputArguments[1];
     PrintMinIndex (numbers,minType);
     break;
     case "fist":
     int firstCount = int.Parse(inputArguments[1]);
     string firstType = (inputArguments[2]);
     PrintFirstElements(numbers,firstCount,firstType);
     break;
     case "last":
     int lastCount = int.Parse(inputArguments[1]);
     string lastType = (inputArguments[2]);
     PrintFirstElements(numbers,lastCount,lastType);
     break;
    }
}

Console.WriteLine($"[{string.Join(", ", numbers)}]");

static void PrintLastElements(int[] numbers,int count, string type){

if(count> numbers.Length){

    Console.WriteLine("Invalid count");
    return;
}

string lastElements = string.Empty;
int elementsCount = 0;

for (int i = numbers.Length-1; i>=0; i--){
   int number = numbers[i];
    if (IsOddOrEven(type,number)){

        lastElements = $"{number}, " + lastElements;
        elementsCount++;
        if(elementsCount>=count){

            break;
        }
    }
}

Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");
}

static void PrintFirstElements(int[] numbers,int count, string type){

if(count> numbers.Length){

    Console.WriteLine("Invalid count");
    return;
}

string firstElements = string.Empty;
int elementsCount = 0;

for (int i = 0; i<numbers.Length; i++){
   int number = numbers[i];
    if (IsOddOrEven(type,number)){

        firstElements += $"{number}, ";
        elementsCount++;
        if(elementsCount>=count){

            break;
        }
    }
}

Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
}

static int[] ExchangeElements(int[] array, int index){
   if (CheckForOutOfRange(array,index)){
     
     Console.WriteLine("Invalid index");
     return array;
   }

   int[] changedArray = new int[array.Length];
   int changedArrayIndex = 0;

   for (int i = index+1; i<=array.Length-1; i ++ ){

    changedArray[changedArrayIndex++] = array[i];
   }

   for (int i = 0; i<=index; i++){

    changedArray[changedArrayIndex++] = array[i];
   }
    
    return changedArray;
}

static bool CheckForOutOfRange(int[] array, int index){
    return index < 0 || index >= array.Length;
}

void PrintMaxIndex(int[] numbers, string maxType){
    int maxIndex = -1;
    int maxNumber = int.MinValue;

    for(int i = 0; i < numbers.Length; i++){

        int number = numbers[i];
        if (IsOddOrEven(maxType,number)){

           if (number >= maxNumber){

            maxNumber = number;
            maxIndex = i;
           }
        }
        
        PrintNotDefaultIndex(maxIndex);

    }
}

void PrintMinIndex(int[] numbers, string minType){
    int minIndex = -1;
    int maxNumber = int.MaxValue;

    for(int i = 0; i < numbers.Length; i++){

        int number = numbers[i];
        if (IsOddOrEven(minType,number)){

           if (number <= maxNumber){

            maxNumber = number;
            minIndex = i;
           }
        }
        
        PrintNotDefaultIndex(minIndex);

    }
}

static bool IsOddOrEven(string type, int number){

    return (type == "even" && number % 2 == 0) ||
           (type == "odd" && number % 2 != 0);
}

static void PrintNotDefaultIndex(int maxIndex){

     if (maxIndex != -1){
        
            Console.WriteLine(maxIndex);
        }
     else{

            Console.WriteLine("no matches");
        }
}


 