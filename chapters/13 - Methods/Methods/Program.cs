using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

Random random = new Random();

string user1Name = AskForUsername("User 1, please enter a username between 1 and 12 characters (can only use letters, numbers, or underscores): ", 12);
string user2Name = AskForUsername("User 2, please enter a username between 1 and 12 characters (can only use letters, numbers, or underscores): ", 12);
string dealerName;
int dealerIndex = GenerateDealer(out dealerName);

int user1StartingNumber = AskForNumberInRange($"{user1Name}, please enter a number between 1 and 10: ", 1, 10);

Console.WriteLine($"Great. You chose {user1StartingNumber}. This is your starting number.");

int user2StartingNumber = AskForNumberInRange($"{user2Name}, please enter a number between 1 and 10: ", 1, 10);
Console.WriteLine($"Great. You chose {user2StartingNumber}. This is your starting number. Remember these.");

int dealerStartingNumber = random.Next(1, 11);

Console.Clear();

Console.WriteLine("Now that you have chosen your starting numbers, you must each take turns choosing a new number between -10 and 10.\n");
Console.WriteLine("Your chosen numbers will be then be added to the total.\n");
Console.WriteLine("The goal is to get as close to 100 as possible without going over.");
Console.WriteLine("To make things more interesting, each time you choose a number, I will also choose a number between 1 and 10 to add to or subtract from your total.\n");
Console.WriteLine("Good luck, and have fun!");

int startingTotal = user1StartingNumber + user2StartingNumber;
int totalThreshold = 100;
int userTotal = startingTotal;
int dealerTotal = dealerStartingNumber * 2;

int numberOfTurnsTaken = 0;
int maximumTurns = 10;

while (userTotal < totalThreshold && dealerTotal < totalThreshold && numberOfTurnsTaken < maximumTurns)
{
    int operationType = random.Next(1, 3);
    int numberToAddOrSubtract = random.Next(1, 11);

    int user1Number = AskForNumberInRange($"{user1Name}, please choose a number.", -10, 10);
    Console.WriteLine();

    int user2Number = AskForNumberInRange($"{user2Name}, please choose a number.", -10, 10);
    Console.WriteLine($"{dealerName}: ");
    DisplayRandomResponse(dealerIndex);
    Console.WriteLine();

    int dealerNumber = random.Next(1, 11);

    if (dealerTotal > 90)
    {
        dealerNumber = random.Next(1, 6);
    }
    else if (dealerTotal >= 95 && dealerTotal < 99)
    {
        dealerNumber = random.Next(-6, 6);
    }

    userTotal += user1Number + user2Number;
    dealerTotal += dealerNumber;

    if (operationType == 1)
        userTotal += numberToAddOrSubtract;
    else
        userTotal -= numberToAddOrSubtract;

    Console.WriteLine($"Current total: {userTotal}");

    numberOfTurnsTaken++;

    if (dealerTotal > 100 && userTotal <= 100)
    {
        Console.WriteLine($"{dealerName} went over 100 with {dealerTotal}, {user1Name} and {user2Name} win with {userTotal}!");
        break;
    }
    else if (userTotal > 100 && dealerTotal <= 100)
    {
        Console.WriteLine($"{user1Name} and {user2Name} went over 100 with {userTotal}, {dealerName} wins with {dealerTotal}!");
        break;
    }
    else if (userTotal > 100 && dealerTotal > 100)
    {
        Console.WriteLine($"Both went over 100, no one wins! {user1Name} and {user2Name} have {userTotal}, {dealerName} has {dealerTotal}.");
        break;
    }
    else if (dealerTotal == 100 && userTotal < 100)
    {
        Console.WriteLine($"{dealerName} hit 100 with {dealerTotal}, {user1Name} and {user2Name} have {userTotal}, {dealerName} wins!");
        break;
    }
    else if (userTotal == 100 && dealerTotal < 100)
    {
        Console.WriteLine($"{user1Name} and {user2Name} hit 100 with {userTotal}, {dealerName} has {dealerTotal}, {user1Name} and {user2Name} win!");
        break;
    }
    else if (dealerTotal == 100 && userTotal == 100)
    {
        Console.WriteLine($"Both hit 100, both win! {user1Name} and {user2Name} have {userTotal}, {dealerName} has {dealerTotal}.");
        break;
    }
    else if (numberOfTurnsTaken == maximumTurns && dealerTotal > userTotal)
    {
        Console.WriteLine($"{dealerName} has a higher total with {dealerTotal}, {dealerName} wins! {user1Name} and {user2Name} have {userTotal}.");
        break;
    }
    else if (numberOfTurnsTaken == maximumTurns && userTotal > dealerTotal)
    {
        Console.WriteLine($"{user1Name} and {user2Name} have a higher total with {userTotal}, {user1Name} and {user2Name} win! {dealerName} has {dealerTotal}.");
        break;
    }
    else if (numberOfTurnsTaken == maximumTurns && userTotal == dealerTotal)
    {
        Console.WriteLine($"It's a tie! {user1Name} and {user2Name} have {userTotal}, {dealerName} has {dealerTotal}.");
        break;
    }

}

Console.WriteLine("--------------------Game Over.--------------------");
int AskForNumber(string text)
{
    while (true)
    {
        Console.WriteLine(text);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
            return number;

        Console.WriteLine($"Sorry, the number {number} is invalid. Try again.");
    }
}

string AskForUsername(string text, int characterMax)
{
    Console.WriteLine(text);
    while (true)
    {
        string username = Console.ReadLine();

        if (username.Length > 0 && username.Length <= characterMax && Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
        {
            Console.WriteLine($"You have chosen the username {username}.\n");
            return username;
        }

        Console.WriteLine("That is an invalid username. Usernames must be 1-12 characters long and can only include letters, numbers, or underscores. Please try again.\n");
    }
}

int GenerateDealer(out string dealerName)
{
    string[,] dealerNamesAndEntrancePhrases =
        {
        { "Chad Thundercock the Supreme Overlord of Chads", "Bros before hoes! I'll always win with my bros on my side. I love my bros, no homo." },
        { "Britney Spearmint the Goddess of Pride", "Um, like, I'm Britney, bitch." },
        { "Terry Whinerman, Destroyer of Racism", "If you so much as think about winning, I'll report you to the BBC." },
        { "Yusef Mangelev's Rotting Corpse, Hailer of Hipsters", "Mrgl drgl rrgghh nnnggg HAIL HIP-grglgrgl!" },
        { "Mrs. Mickey Tyson, Angel of Death and Hairspray", "Thith ith going to be eathy." },
        { "Krump", "I'm gonna win big, real big, as big as I can, I'll win so big like you've never seen, and I always win." },
        { "Not Three Chipmunks in a Trenchcoat", "*squeak* Ahem, excuse me, I'm running late." },
        { "Catman", "There's darkness encroaching upon Markham, so you know what that means! Time to run around, open all the doors, and scratch everything!" }
        };

    int randomIndex = random.Next(dealerNamesAndEntrancePhrases.GetLength(0));
    dealerName = dealerNamesAndEntrancePhrases[randomIndex, 0];
    string dealerPhrase = dealerNamesAndEntrancePhrases[randomIndex, 1];

    Console.WriteLine($"This game, you will be facing off against {dealerName}.");
    Console.WriteLine($"{dealerName}: \"{dealerPhrase}\"\n");

    return randomIndex;
}

void DisplayRandomResponse(int dealerIndex)
{
    string[,] dealerResponses = new string[,]
    {
        { "That's not how we do it, bro!", "Bro, what are you doing?", "Come on, bro, get it together!" },
        { "Ew, that's not good.", "Uh, no.", "Try harder, duh!" },
        { "Are you trying to insinuate something about my skin color?", "Wow, that says a lot about how you feel about my people.", "You're making everyone of your people look bad." },
        { "Gbbrrbgg.", "RAGGGHHH.", "Hmmglph." },
        { "Thufferin' thuckatath.", "THINK, motherfucker, THINK!", "That'th wack." },
        { "Thufferin' thuckatath.", "THINK, motherfucker, THINK!", "That'th wack." },
        { "Thufferin' thuckatath.", "THINK, motherfucker, THINK!", "That'th wack." },
        { "Thufferin' thuckatath.", "THINK, motherfucker, THINK!", "That'th wack." },
    };

    int responseIndex = random.Next(0, 3);

    Console.WriteLine(dealerResponses[dealerIndex, responseIndex]);
}

int RecursionMethod(int number)
{
    if (number == 0) return 0;
    Console.WriteLine(number);
    return RecursionMethod(number - 1);
}