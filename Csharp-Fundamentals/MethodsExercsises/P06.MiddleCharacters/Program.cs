string input = Console.ReadLine();

MiddleCharacters(input);

void  MiddleCharacters(string input){
if (input.Length % 2 == 0){
    char[] arr = input.ToCharArray();
    int mid = arr[arr.Length/2];
    Console.WriteLine($"{arr[mid]} {arr[mid+1]}");
}
else{
    char[] arr = input.ToCharArray();
    int mid = arr[arr.Length/2];
    Console.WriteLine($"{arr[mid]}");
}
}