List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();

for (int i = 0; i < numbers.Count; i ++){

    if (bomb[0] == numbers[i]){

       int start = i - bomb[1];

       if(start < 0){

        start = 0;
       }

       int finish = i + bomb[1] + 1;
       
       if (finish>numbers.Count){

        finish = numbers.Count;
       }

       for (int j = start; j < finish; j++){

        numbers[j] = 0;
       }
    }
}

Console.WriteLine(numbers.Sum());
