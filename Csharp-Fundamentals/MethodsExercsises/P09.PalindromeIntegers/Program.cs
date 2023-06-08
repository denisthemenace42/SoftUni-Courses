string input = string.Empty;
while((input = Console.ReadLine()) != "END"){
     
     Console.WriteLine(isPalindrome(input));

    }

static bool isPalindrome(string input){
    string first = input.Substring(0,input.Length/2);
    char[] arr = input.ToCharArray();

    Array.Reverse(arr);
    
    string temp = new string(arr);
    string second = temp.Substring(0,temp.Length/2);

    return first == second;
}
