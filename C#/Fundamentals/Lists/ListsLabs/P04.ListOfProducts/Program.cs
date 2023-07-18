List<string> products = new List<string>();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++){

    products.Add(Console.ReadLine());
}

products.Sort();

for (int j = 0; j<count;j++){

    Console.WriteLine($"{j+1}.{products[j]}");
}