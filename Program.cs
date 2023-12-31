﻿using System;

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

int GetNumber()
{
    string userOption = Console.ReadLine();
    int result;
      while (!int.TryParse(userOption, out result))
    {
        Console.WriteLine("Please enter a number");
        userOption = Console.ReadLine();
    }
    return result;
}
string askQuestion(string question, params string[] options)
{
    Console.WriteLine(question);
    int listNumber = 1;
    foreach (string option in options)
    {
        Console.Write(listNumber);
        Console.Write(" ");
        Console.WriteLine(option);
        listNumber++;
    }
    int result = GetNumber();
    while (result > options.Length || result <= 0)
    {
        Console.WriteLine("Please enter a valid number");
        result = GetNumber();
    }
    result--;
    return options[result];
}

askQuestion("An orc has appeared. What would you like to do?", "Fight", "Run", "Use an item");

