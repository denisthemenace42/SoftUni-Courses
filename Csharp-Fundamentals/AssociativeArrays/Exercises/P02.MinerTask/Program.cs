string input;

Dictionary<string,int> resources = new Dictionary<string, int>();
int quantity;

while ((input=Console.ReadLine()) != "stop"){

    quantity = int.Parse(Console.ReadLine());

    resources[input] = quantity;

}

foreach(KeyValuePair<string,int> pair in resources){

    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}