﻿int count = int.Parse(Console.ReadLine());

List<string>phrases = new List<string>
{"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."};
List<string>events = new List<string>
{"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
List<string>authors = new List<string>
{"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
List<string>cities = new List<string>
{"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

Random rnd = new Random();

for (int i = 0; i < count; i++){

int randomIndex = rnd.Next(phrases.Count);
int randomIndex2 = rnd.Next(events.Count);
int randomIndex3 = rnd.Next(authors.Count);
int randomIndex4 = rnd.Next(cities.Count);

string randomPhrase = phrases[randomIndex];
string randomEvent = events[randomIndex2];
string randomAuthor = authors[randomIndex3];
string randomCity = cities[randomIndex4];

Console.WriteLine($"{randomPhrase} {randomEvent} {randomAuthor} - {randomCity}.");
}
