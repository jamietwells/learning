askQuestion("Choose your gender", "Male", "Female");
askQuestion("Choose your class", "Mage", "Warrior", "Rogue");
askQuestion("Choose your weapon", "Staff", "Sword", "Spear");
askNumber("What strength will your character have?");
askNumber("What dexterity will your character have?");
askNumber("What wisdom will your character have?");
askNumber("What charisma will your character have?");

int askNumber(string question)
{
    Console.WriteLine(question);

    string value = Console.ReadLine();
    bool valid = IsNumber(value);
    while (!valid)
    {
        Console.WriteLine("Invalid number. Please try again");
        value = Console.ReadLine();
        valid = IsNumber(value);

    }
    int valueConverted = Convert.ToInt32(value);
    return valueConverted;
}

bool IsNumber(string input)
{
    foreach (char item in input)
    {
        if (!IsCharNumber(item))
            return false;
    }
    return true;
}
bool IsCharNumber(char input)
{
    if (input == '0')
        return true;
    if (input == '1')
        return true;
    if (input == '2')
        return true;
    if (input == '3')
        return true;
    if (input == '4')
        return true;
    if (input == '5')
        return true;
    if (input == '6')
        return true;
    if (input == '7')
        return true;
    if (input == '8')
        return true;
    if (input == '9')
        return true;
    return false;
}


bool arrayContains(string[] items, string item)
{
    foreach (string validOption in items)
    {
        if (item == validOption)
        {
            return true;
        }
    }
    return false;
}



string askQuestion(string question, params string[] options)
{
    Console.WriteLine(question);
    string userOption = Console.ReadLine();

    while (!arrayContains(options, userOption))
    {
        Console.WriteLine("Incorrect option, pick again");
        userOption = Console.ReadLine();
    }
    return userOption;
}

