char input1 = char.Parse(Console.ReadLine());
char input2 = char.Parse(Console.ReadLine());

CharInRange(input1,input2);

static void CharInRange(char ch1, char ch2){
   
    int firstChar = Math.Min(ch1,ch2);
    int secondChar = Math.Max(ch1,ch2);
    for (int i = ++firstChar;i<secondChar;i++){

     Console.Write((char)i + " ");
    }

}