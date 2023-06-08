int number = int.Parse(Console.ReadLine());
NxNMatrix(number);

void NxNMatrix(int number){
    for(int i = 1;i<=number;i++){

        for (int j =1;j<=number;j++){
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
}
