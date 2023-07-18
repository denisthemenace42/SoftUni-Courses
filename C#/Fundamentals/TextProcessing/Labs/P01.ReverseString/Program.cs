
string text = string.Empty;

while ((text = Console.ReadLine()) != "end")
{
    string reversed = string.Empty;
    for ( int i = text.Length - 1; i >= 0; i--){

        reversed += text[i];
    }

    Console.WriteLine($"{text} = {reversed}");

}
