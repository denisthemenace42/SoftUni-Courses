string[] input = Console.ReadLine().Split(", ").ToArray();
int commandsCount = int.Parse(Console.ReadLine());

Article article = new Article(input[0],input[1],input[2]);


for (int i = 0; i < commandsCount; i++){
    
    string[] tokens = Console.ReadLine().Split(": ");
    string command = tokens[0];
    string argument = tokens[1];
    switch(command){

        case "Edit":
        article.Edit(argument);
        break;

        case "ChangeAuthor":
        article.ChangeAuthor(argument);
        break;

        case "Rename":
        article.Rename(argument);
        break;
    }
}

Console.WriteLine(article.ToString());
public class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title {get; set;}

    public string Content {get; set;}

    public string Author {get; set;}

    public void Edit(string newContent){

        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor){

        Author = newAuthor;
    }

    public void Rename(string newTitle){

        Title = newTitle;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}