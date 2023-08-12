askQuestion("Choose your gender", "Male", "Female");
askQuestion("Choose your class", "Mage", "Warrior", "Rogue");
askQuestion("Choose your weapon", "Staff", "Sword", "Spear");


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

    static bool arrayContains(string[] items, string item)
    {
        int currentOption = 0;

        while (currentOption < items.Length)
        {
            string validOption = items[currentOption];
            currentOption = currentOption + 1;


            if (item == validOption)
            {
                return true;
            }
        }
        return false;
    }

}

