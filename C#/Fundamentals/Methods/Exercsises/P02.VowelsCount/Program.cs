string input = Console.ReadLine().ToLower();

Console.WriteLine(VowelsCount(input));


static int VowelsCount(string input){
    int sum = 0;
    for(int i = 0; i < input.Length; i++){
         if (input[i]  == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
        {
            sum++;
        }
    
         }
    
    return sum;
}