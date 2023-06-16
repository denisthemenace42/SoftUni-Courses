List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();



while (true){

    if (firstDeck[0] > secondDeck[0]){

        firstDeck.Add(firstDeck[0]);
        firstDeck.Add(secondDeck[0]);
    }

    else if (firstDeck[0] < secondDeck[0]){

        secondDeck.Add(secondDeck[0]);
        secondDeck.Add(firstDeck[0]);
    }

    firstDeck.Remove(firstDeck[0]);
    secondDeck.Remove(secondDeck[0]);

    if (firstDeck.Count == 0){

        int sum = secondDeck.Sum();
        Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
        break;

    }

    else if (secondDeck.Count == 0){

        int sum = firstDeck.Sum();
        Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
        break;

    }
    
}







