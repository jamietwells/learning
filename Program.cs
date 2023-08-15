using System;

askQuestion("Choose your gender", "Male", "Female");
askQuestion("Choose your class", "Mage", "Warrior", "Rogue");
askQuestion("Choose your weapon", "Staff", "Sword", "Spear");
askNumber("What strength will your character have?");
// askNumber("What dexterity will your character have?");
// askNumber("What wisdom will your character have?");
// askNumber("What charisma will your character have?");

int askNumber(string question)
{
    Console.WriteLine(question);

    string value = Console.ReadLine();
    int result;
    while (!int.TryParse(value, out result))
    {
        Console.WriteLine("Invalid number. Please try again");
        value = Console.ReadLine();
    }
    return result;
}

string askQuestion(string question, params string[] options)
{
    Console.WriteLine(question);
    string userOption = Console.ReadLine();

    while (!options.Contains(userOption))
    {
        Console.WriteLine("Incorrect option, pick again");
        userOption = Console.ReadLine();
    }
    return userOption;
}