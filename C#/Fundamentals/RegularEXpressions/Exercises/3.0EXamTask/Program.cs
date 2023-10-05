using System.ComponentModel.DataAnnotations.Schema;
string spell = Console.ReadLine();
string input;

while ((input = Console.ReadLine()) != "Abracadabra")
{

    string[] commands = input.Split(" ");

    if (commands[0] == "Abjuration")
    {
        spell = spell.ToUpper();
        Console.WriteLine(spell);

    }

    else if (commands[0] == "Necromancy")
    {
        spell = spell.ToLower();
        Console.WriteLine(spell);

    }

    else if (commands[0] == "Illusion")
    {
        int index = int.Parse(commands[1]);
        char letter = char.Parse(commands[2]);

        if (index >= 0 && index < spell.Length)
        {
            spell = spell.Remove(index, 1).Insert(index, letter.ToString());
            Console.WriteLine("Done!");
        }
        else 
        {
            Console.WriteLine("The spell was too weak.");
        }

    }
    else if (commands[0] == "Divination")
    {
        string firstSub = commands[1];
        string secondSub = commands[2];

        if (spell.Contains(firstSub))
        {
            spell = spell.Replace(firstSub,secondSub);
            Console.WriteLine(spell);
        }

    }

    else if (commands[0] == "Alteration")
    {
        string subString = commands[1];

        if (spell.Contains(subString))
        {
            spell = spell.Replace(subString, "");
            Console.WriteLine(spell);
        }

    }
    else
    {
        Console.WriteLine("The spell did not work!");
    }


}