
string str = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

static string RepeatString(string str, int count)
{
string result = "";
for (int i = 0; i<count; i++){
    result += str;
}
return result;
}

string result = RepeatString(str,count);
Console.WriteLine(result);
