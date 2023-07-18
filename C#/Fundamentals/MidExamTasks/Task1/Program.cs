List<string> books = Console.ReadLine().Split("&").ToList();

string input;

while ((input = Console.ReadLine()) != "Done"){

string[] commands = input.Split(" | ");

switch(commands[0]){

    case "Add Book":
    string addBook = commands[1];
    if (books.Contains(addBook)){
        break;
    }
    else {
        books.Insert(0,addBook);
    }
    break;

    case "Take Book":
    string removeBook = commands[1];
      if (books.Contains(removeBook)){
        
        books.Remove(removeBook);
    }
    break;

    case "Swap Books":
    string bookName1 = commands[1];
    string bookName2 = commands[2];
     int index1 = 0;
     int index2 = 0;
    if (books.Contains(bookName1) && books.Contains(bookName2)){

     for (int j = 0; j < books.Count; j++){

        if (books[j] == bookName1){
            index1 = j;
        }

        if (books[j] == bookName2){
            index2 = j;
        }
     }

     (books[index1],books[index2]) = (books[index2],books[index1]);
    }
    break;

    case "Insert Book":
    string insertBook = commands[1];
    if (books.Contains(insertBook)){
     
     break;
    }
    else{


        books.Add(insertBook);
    }
    break;

    case "Check Book":
    int index = int.Parse(commands[1]);

    if (index >= 0 && index < books.Count){

        for (int n = 0; n < books.Count; n++){

            if (n == index){

                Console.WriteLine(books[n]);
            }
        }
    }
    break;
}
}

Console.WriteLine(string.Join(", ",books));
