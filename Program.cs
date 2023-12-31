/* Level 6 Challenge: Variable Shop (and Returns) 

byte number0 = 255;
short number1 = 32767;
int number2 = 2147483647;
long number3 = 4294967294L;
sbyte number4 = 127;
ushort number5 = 65535;
uint number6 = 4294967294;
ulong number7 = 8589934588;
float number8 = 123456.1234561919104f;
double number9 = 987654321.1234567890;
decimal number10 = 1234567.1234567m;
string text = "Hello!";
char character = 'z';
bool isComplete = true;

number0 = 1;
number1 = 2;
number2 = 3;
number3 = 4;
number4 = 5;
number5 = 6;
number6 = 7;
number7 = 8;
number8 = 9.23456f;
number9 = 10.12312415f;
number10 = 500.10005m;
text = "What did you say?";
character = 'A';
isComplete = false;

Console.WriteLine(number0);
Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);
Console.WriteLine(number4);
Console.WriteLine(number5);
Console.WriteLine(number6);
Console.WriteLine(number7);
Console.WriteLine(number8);
Console.WriteLine(number9);
Console.WriteLine(number10);
Console.WriteLine(text);
Console.WriteLine(character);
Console.WriteLine(isComplete); */

/* Level 7 Challenge: The Triangle Farmer 

// Declaring string variables for when user inputs text into the Console window
string baseText;
string heightText;

// Declaring double variables for converting what user types as the number for their triangle's sides and height into real numbers
double baseNumber;
double heightNumber;

// Allowing user to assign the value to the variables of the triangle's sides and height by typing in the Console window
Console.WriteLine("How many inches is the first side of your triangle?");
baseText = Console.ReadLine();
baseNumber = Convert.ToDouble(baseText);
Console.WriteLine("Okay, " + baseNumber + "." + " Got it. Now how many inches is its height?");
heightText = Console.ReadLine();
heightNumber = Convert.ToDouble(heightText);
Console.WriteLine("Sweet! So your triangle has a base of " + baseNumber + " inches, and a height of " + heightNumber + " inches!" +
    " Let me just divide that by 2 and...");
double triangleArea = baseNumber * heightNumber / 2;
Console.WriteLine("Alright, so I've figured it out! Your triangle has an area of " + triangleArea + " inches. Awesome!"); */

/* Level 7 Challenge: The Four Sisters and the Duckbear

Console.WriteLine("How many eggs have the Four Sisters gathered today?");
string eggsGatheredTodayText = Console.ReadLine();
int eggsGatheredTodayNumber = Convert.ToInt32(eggsGatheredTodayText);
Console.WriteLine("So the sisters have gathered " + eggsGatheredTodayNumber + " eggs today? Great.");
int eggsForEachSister = eggsGatheredTodayNumber / 4;
int remainingEggsForDuckbear = eggsGatheredTodayNumber % 4;
Console.WriteLine("I have determined that each sister should get " + eggsForEachSister + " eggs, and their duckbear should get " + remainingEggsForDuckbear + " eggs.");

// Answer this question: What are three total egg counts where the duckbear gets more than each
// sister does? You can use the program you created to help you find the answer.
// 
// Really small numbers would work. Anything less than 4 (except 0) would give the duckbear more than the sisters, so 1, 2, and 3.
// The number 6 would work, leaving 2 eggs for the duckbear, and so would 7, leaving 3 eggs for the duckbear. The same applies to the number 11. */

/* Level 7 Challenge: The Dominion of Kings
Console.WriteLine("How many provinces do you have?");

int provincesCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nice, " + provincesCount + " provinces.");

Console.WriteLine("How many duchies do you have?");

int duchiesCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Oooh, you have " + duchiesCount + " duchies? Wow.");

Console.WriteLine("Okay, finally, how many estates do you own?");

int estatesCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("AND you have " + estatesCount + " estates? Dayum!");

int provincesPoints = provincesCount * 6;
int duchiesPoints = duchiesCount * 3;
int estatesPoints = estatesCount * 1;
int totalKingdomPoints = provincesPoints + duchiesPoints + estatesPoints;

Console.WriteLine("Okay, so with " + provincesPoints + " points for provinces, " + duchiesPoints + " for duchies, and " + estatesPoints + " for estates, that brings you to a grand total of...");
Console.WriteLine("...");
Console.WriteLine("...");
Console.WriteLine("...");
Console.WriteLine(totalKingdomPoints + " total Kingdom Points!"); */

/* Level 8 Notes
Console.Title = "Big Game Hunter";
Console.Beep(440, 1000);
Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear();
Console.WriteLine("\"");
Console.WriteLine(@"C:\Users\Johnny\Desktop\ProgrammerCode.txt");
Console.Write("Hello programmer, what is your name? ");
string programmerName = Console.ReadLine();
Console.Write("How old are you? ");
string programmerAge = Console.ReadLine();
Console.Write("Where are you from? ");
string programmerLocation = Console.ReadLine();
Console.WriteLine("Press any key to continue.");
Console.ReadKey(true);
Console.WriteLine("What are your three favorite foods?");
string programmerFavoriteFood1 = Console.ReadLine();
string programmerFavoriteFood2 = Console.ReadLine();
string programmerFavoriteFood3 = Console.ReadLine();
Console.WriteLine($"{programmerFavoriteFood1} sounds really good right about now. Not sure about {programmerFavoriteFood3}, though.");
Console.WriteLine("Who is your hero?");
string programmerHeroName = Console.ReadLine();
Console.WriteLine("What is your favorite game?");
string programmerFavoriteGame = Console.ReadLine();
Console.WriteLine("These are your answers so far:");
Console.WriteLine($"{programmerName, 20}");
Console.WriteLine($"{programmerAge,20}");
Console.WriteLine($"{programmerLocation,20}");
Console.WriteLine($"{69420:000000.000000}");
Console.WriteLine($"{99.9412312455:#.###}");
float currentHitpoints = 20;
float maxHitpoints = 100;
Console.WriteLine($"{currentHitpoints / maxHitpoints:0.0%}"); /*

/* Level 8 Challenge: The Defense of Consolas
Console.Title = "The Defense of Consolas";

Console.WriteLine("What is the target row?");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the target column?");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Deploying defenses at Row {targetRow}, Column {targetColumn+1}");
Console.Beep();
Console.WriteLine($"Deploying defenses at Row {targetRow}, Column {targetColumn - 1}");
Console.Beep();
Console.WriteLine($"Deploying defenses at Row {targetRow + 1}, Column {targetColumn}");
Console.Beep();
Console.WriteLine($"Deploying defenses at Row {targetRow - 1}, Column {targetColumn}");
Console.Beep();
*/

/* Level 9 Challenge: Repairing the Clocktower 
Console.WriteLine("Enter a number for the Clocktower.");
int clockNumber = Convert.ToInt32(Console.ReadLine());
bool numberIsEven = clockNumber % 2 == 0; // If the int is evenly divisible by 2, there will be no remainder, so the int is even.

if (numberIsEven)
{
    Console.WriteLine("Tick.");
    Console.Beep(1200, 5);
}
else
{
    Console.WriteLine("Tock.");
    Console.Beep(600, 5);
}
*/

/* Level 9 Challenge: Watchtower
Console.Title = "The Watchtower";
Console.WriteLine("An enemy is approaching Consolas! We need their coordinates!");
int watchtowerXCoordinate = 0;
int watchtowerYCoordinate = 0;

Console.Write("Enemy X Coordinate: ");
int enemyXCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Enemy Y Coordinate: ");
int enemyYCoordinate = Convert.ToInt32(Console.ReadLine());

bool enemyIsNorth = enemyXCoordinate == watchtowerXCoordinate && enemyYCoordinate > watchtowerYCoordinate;
bool enemyIsNortheast = enemyXCoordinate > watchtowerXCoordinate && enemyYCoordinate > watchtowerYCoordinate;
bool enemyIsEast = enemyXCoordinate > watchtowerXCoordinate && enemyYCoordinate == watchtowerYCoordinate;
bool enemyIsSoutheast = enemyXCoordinate > watchtowerXCoordinate && enemyYCoordinate < watchtowerYCoordinate;
bool enemyIsSouth = enemyXCoordinate == watchtowerXCoordinate && enemyYCoordinate < watchtowerYCoordinate;
bool enemyIsSouthwest = enemyXCoordinate < watchtowerXCoordinate && enemyYCoordinate < watchtowerYCoordinate;
bool enemyIsWest = enemyXCoordinate < watchtowerXCoordinate && enemyYCoordinate == watchtowerYCoordinate;
bool enemyIsNorthwest = enemyXCoordinate < watchtowerXCoordinate && enemyYCoordinate > watchtowerYCoordinate;
bool enemyIsAtWatchtower = enemyXCoordinate == watchtowerXCoordinate && enemyYCoordinate == watchtowerYCoordinate;

if (enemyIsNorth)
{
    Console.WriteLine("The enemy is north of the Watchtower!");
}
if (enemyIsNortheast)
{
    Console.WriteLine("The enemy is northeast of the Watchtower!");
}
if (enemyIsEast)
{
    Console.WriteLine("The enemy is east of the Watchtower!");
}
if (enemyIsSoutheast)
{
    Console.WriteLine("The enemy is southeast of the Watchtower!");
}
if (enemyIsSouth)
{
    Console.WriteLine("The enemy is south of the Watchtower!");
}
if (enemyIsSouthwest)
{
    Console.WriteLine("The enemy is southwest of the Watchtower!");
}
if (enemyIsWest)
{
    Console.WriteLine("The enemy is west of the Watchtower!");
}
if (enemyIsNorthwest)
{
    Console.WriteLine("The enemy is northwest of the Watchtower!");
}
if (enemyIsAtWatchtower)
{
    Console.WriteLine("The enemy is at the Watchtower! RUUUUUUN!");
} */

/* *** Level 10 - Switches NOTES ***

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice) // the switch is like a fancy `if` statement, and tries to find which arm (the contents in each `case`) to run,
                // or default if none match. in a switch STATEMENT, the target (int `choice` in this case) comes after `switch`.
                // it's then followed by curly braces {} where `case`s are put inside to delineate each condition needed for the arms.
{
    case 1: // the case keyword represents each arm of the switch statement, with the value of (choice) written after `case`
            // when that value of (choice) matches the case, the statements inside of the case run until they hit `break`.
        Console.WriteLine("Ye rest and recover yer health."); // the contents inside of a case are called an 'arm'.
        break; // break signals the flow of execution of the code to stop here, exit the switch statement, and continue as normal
    case 2:
        Console.WriteLine("Raiding the port town yields ye 50 gold doubloons.");
        break;
    case 3:
        Console.WriteLine("The wind's at yer back, the open horizon ahead.");
        break;
    case 4:
        Console.WriteLine("'Tis but a baby Kraken, but 'e still eats toy ships!");
        break;
    default: // default is put at the end of all the cases in a switch statement, and is what's run if no case's condition(s) are met.
        Console.WriteLine("Oi matey, I don't know what ye mean. Arr!");
        break;
}

int choice = Convert.ToInt32(Console.ReadLine());
string response;

response = choice switch // switch EXPRESSIONS have a lot in common with switch statements, but have a few key differences.
                         // for starters, in a switch expression, the target (the int `choice` in this case) comes before `switch`.
                         // also, much of the clutter of the switch statement is removed or simplified to streamline the code.
                         // `case`s are gone and replaced with the value (`choice`) you want to check for, for instance.
                         // each arm also has the arrow operator (`=>`) which separate's the arm's condition from its expression.
                         // even the `break`s are gone; the arms can only have one expression, so there's no need to indicate the end.
                         // each arm is separated by a comma now, and are put on separate lines as well (usually).
                         // the `default` keyword is now gone, too, and replaced with `_`—the `wildcard`.
                         // in a switch statement, `default` isn't needed. you can just tell the code not to run anything if the cases
                         // aren't met. but in a switch expression, it NEEDS to evaluate something. if your epxression doesn't cover a
                         // scenario, the program won't proceed and will crash as a result. you'll want to ensure a switch expression
                         // covers all possible inputs. that's where the wildcard `_` comes in, to handle any possible weird inputs.
{
    1 => "Ye rest and recover yer health.",
    2 => "Raiding the port town yields ye 50 gold doubloons.",
    3 => "The wind's at yer back, the open horizon ahead.",
    4 => "'Tis but a baby Kraken, but 'e still eats toy ships!",
    _ => "Oi matey, I don't know what ye mean. Arr!"
}; */

/* Level 10 Challenge: Buying Inventory | Discounting Inventory

Console.Write("Oi matey, name's Tortuga. What's yer name? ");
string username = Console.ReadLine();
bool isShopDiscounted = username == "Johnny";

if (isShopDiscounted)
{
    Console.WriteLine(
    "Hey, Johnny! Thanks for the help again, matey! This is what I've got in stock, half off just for you!:" +
    "\n 1—Rope" +
    "\n 2—Torches" +
    "\n 3—Climbing Gear" +
    "\n 4—Fresh Water" +
    "\n 5—Machete" +
    "\n 6—Canoe" +
    "\n 7—Food");
}
else
{
    Console.WriteLine(
    "Hurry up will ya? This is what I've got:" +
    "\n 1—Rope" +
    "\n 2—Torches" +
    "\n 3—Climbing Gear" +
    "\n 4—Fresh Water" +
    "\n 5—Machete" +
    "\n 6—Canoe" +
    "\n 7—Food");
}

Console.Write("What do ye wanna look at? ");
int shopPriceChoice = Convert.ToInt32(Console.ReadLine());

int itemPrice1 = isShopDiscounted? 2 : 5;
int itemPrice2 = isShopDiscounted? 7 : 15;
int itemPrice3 = isShopDiscounted? 15 : 30;
int itemPrice4 = isShopDiscounted? 25 : 50;
int itemPrice5 = isShopDiscounted? 15 : 30;
int itemPrice6 = isShopDiscounted? 50 : 100;
int itemPrice7 = isShopDiscounted? 1 : 2;

string shopResponse;

shopResponse = shopPriceChoice switch
{
    1 => "Rope's gonna cost ye " + itemPrice1 + " gold.",
    2 => "Torches are " + itemPrice2 + " gold a piece.",
    3 => "Climbing gear includes rope, and'll cost ye " + itemPrice3 + " gold.",
    4 => "Fresh water's 'ard to find 'round these parts. " + itemPrice4 + " gold fer a gallon o' the stuff.",
    5 => "Ain't the finest metalwork, that, but the machete's still gonna be " + itemPrice5 + " gold.",
    6 => "A canoe? Mate, that's gonna cost ye an arm and a leg. " + itemPrice6 + " gold.",
    7 => "Food's hardtack, dried fruit, and beans. " + itemPrice7 + " gold a pound.",
    _ => "Sorry, mate, I'm not sure what ye mean by that."
};

Console.WriteLine( shopResponse );
*/

/* Level 11: Looping */
// The While Loop
// while (condition)
// {
//     // If the (condition) is met, the code in this block is repeated. Infinitely.
// }
// 1. the while loop will run until the condition is no longer met, and the computer will not read past the while loop until it
// is completely finished. if the condition is not met initially, the while loop will never run at all.
// 2. the loop's condition is only evaluated at the start of each cycle, so if the condition changes in the middle of the loop,
// the code does not immediately exit the loop.
// 3. it's possible to create an infinite loop, where the condition is always true and never becomes false. This is usually a bug
// but sometimes it's done on purpose. if program seems stuck, check to make sure you don't have an infinite loop.
// 4. A loop's condition can be any `bool` expression, and we can use <, >, <=, >=, =, !=, &&, and || in the condition.
// This is an example of a `while` loop:
// 
// int playersNumber = -1;
//
// while (playersNumber < 0 || playersNumber > 10)
// {
//     Console.Write("Enter a number between 0 and 10. ");
//     string playersResponse = Console.ReadLine();
//     playersNumber = Convert.ToInt32(playersResponse);
// }
//
// This code above initializes playersNumber to -1 so that the while loop runs at least once. Variables MUST be initialized before
// they can be used in the loop. If the int is initialized as -1, it's < 0, so one of the conditions of the while loop is met.
// After the user types a number between 0 and 10, playersNumber is set to be greater than 0 and less than 10, and the loop stops.
// Important to note that as long as the FIRST condition of a bool that uses || is met, the code will never evaluate the second one.
//
// The DO/WHILE Loop
// 
// A do/while loop runs through the loop at least once because it puts the condition at the end of the loop rather than at the start.
// 
// Here's an example of the previous while loop made into a do/while loop:
//
// int playersNumber;
//
// do
// {
//     Console.Write("Enter a number between 0 and 10. ");
//     string playersResponse = Console.ReadLine();
//     playersNumber = Convert.ToInt32(playersResponse);
// {
// while (playersNumber < 0 || playersNumber > 10);
//
// At the end of the loop is the while condition, and it must have a semicolon at the end. It's basically saying this in English:
// “Do this block of code while the player's number is less than 0 or more than 10.”
// Also, since this loop always runs at least once, variables don't need to be initialized before the loop, and can instead be
// initialized within the loop itself.
//
// The FOR Loop
//
// Take a look at this example of a while loop:
// int x = 1;
// while (x <= 5)
// {
//      Console.WriteLine(x);
//      x++;
// }
//
// First, the loop above declares an int variable, then initializes x as 1.
// Next, it starts a while loop, then defines the loop's condition (x <= 5).
// Then, it writes the value of x in the Console.
// Finally, it increments x by 1.
// 
// The only real meat of this code is in WriteLine; the rest of it is just loop management. This is where the for loop comes in.
// A for loop lets you pack loop management code into a single line. It's structured like this:
// for (initialization statement; condition to evaluate; updating action)
// {
//      // Do stuff . . .
// }
//
// So if we change the while loop example into a for loop, it looks like this:
// for (int x = 1; x <= 5; x++)
//      Console.WriteLine(x);
//
// The parentheses in the for loop contain the loop management code as three statements separated by semicolons.
//
// The first statement does any one-time setup to get the loop started, and almost always involves declaring and initializing variables.
// The second statement defines the condition of the loop that needs to be evaluated at the start of each loop cycle. A for loop is more
// like a while loop in that if the condition is not met the first time around, the for loop's body won't run at all.
// The third statement defines how to change the variable used in the loop's condition.
//
// Changing the previous code from a while loop to a for loop simplified it, and got rid of the block. However, a for loop can use block
// statements if needed, just like while and do/while loops, or it can use single statements. For certain types of loops, a for loop lets
// the important stuff stand out better than in while or do/while loops, but all have their place.
//
// Most for loops use all three statements, but any of them can be left out if they aren't needed. You may occasionally see a for loop that
// looks like this:
// for (;;) { . . . }
// This indicates a for loop that runs forever with no condition, but you can also use:
// while (true) { . . . }
//
// BREAK Out of Loops and CONTINUE to the Next Pass
//
// The break and continue statements can be used to give you more control over the loop.
// 
// Break makes the loop stop immediately and exit the loop without reevaluating the loop's condition. This lets you escape the loop even if
// the condition is still technically true. Think of break as the STOP button on a music playlist, as it will stop the music completely.
//
// A continue statement makes the loop stop running the current pass through the loop but will go on to the next pass, reevaluate the
// condition, and keep looping if the condition is still met. Think of continue as the SKIP button on a music playlist, as it will skip
// the current song (AKA this pass of the loop) and go on to the next one (AKA the next pass of the loop).
//
// The following code illustrates both of these mechanics:
// ________________________________________________________
// while (true)
// {
//     Console.Write("Think of a number and type it here: ");
//     string userInput = Console.ReadLine();

//     if (userInput == "quit" || userInput == "exit")
//         break;

//     int numberThoughtOf = Convert.ToInt32(userInput);

//     if (numberThoughtOf == 12)
//     {
//         Console.WriteLine("I don't like the number twelve. Pick a different number.");
//         continue;
//     }
//     Console.WriteLine($"I like {numberThoughtOf}, it's the one before {numberThoughtOf + 1}!");
// }
//
// Nesting Loops
//
// You can nest loops inside of loops, if statements inside of loops, and loops inside of if statements! Fancy, huh?
// Nested loops are common when you need to do something with every combination of two sets of things.
// For example, the following displays a basic multiplication table, multiplying the numbers 1 through 10 against the same set of numbers:
// for (int a = 1; a <= 10; a++)
//     for (int b = 1; b <= 10; b++) // This inner loop runs to completion for each cycle of the outer loop. b will go to 10 while a is 1,
// and then b will go to 10 while a is 2, and so on.
//         Console.WriteLine($"{a} * {b} = {a * b}");
//
// This code displays a grid of *’s based on the number of rows and columns dictated by totalRows and totalColumns:
// __________________________________________________________
//int totalRows = 2;
//int totalColumns = 5;

//for (int currentRow = 1; currentRow <= totalRows; currentRow++)
//{
//    for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++) // This will run until completion for each cycle of the outer
//        Console.Write("[]");                                                    // loop. 5 columns will be drawn on 1 row, then 5 on the 2nd,
//                                                                                    and so on.
//    Console.WriteLine();
//}
//
/* Level 11 Challenge: The Prototype (100 XP) 

int pilotsNumber;

do
{
    Console.Write("Pilot, please enter in a number between 0 and 100: "); // A do/while here so that the console writes the line once
    string pilotsResponse = Console.ReadLine();                               // and then checks to see if the while's condition is met
    pilotsNumber = Convert.ToInt32(pilotsResponse);                            // before writing the line again.
}
while (pilotsNumber < 0 || pilotsNumber > 100);

Console.Clear();

Console.Write("Hunter, please enter your guess, a number between 0 and 100: ");
int huntersNumber = Convert.ToInt32(Console.ReadLine());

while (huntersNumber != pilotsNumber)
{
    if (huntersNumber < 0 || huntersNumber > 100)
    {
        Console.Write($"{huntersNumber} is outside of the range. Please choose a number between 0 and 100: ");
        huntersNumber = Convert.ToInt32(Console.ReadLine());
        continue;
    }

    if (huntersNumber > pilotsNumber)
    {
        Console.Write($"{huntersNumber} is too high. What is your next guess? ");
        huntersNumber = Convert.ToInt32(Console.ReadLine());
        continue;
    }
        
    else if (huntersNumber < pilotsNumber)
    {
        Console.Write($"{huntersNumber} is too low. What is your next guess? ");
        huntersNumber = Convert.ToInt32(Console.ReadLine());
        continue;
    }
        
    else if (huntersNumber == pilotsNumber)
        break;
}
Console.WriteLine("You guessed the correct number! A direct hit!"); */

// Level 11 Challenge: Magic Cannon (100 XP)
// Magic cannon draws power from fire gem and electric gem. Every 3rd crank, fire gem activates; every 5th, electric.
// When both line up, makes potent electroflame.
//
// • Write a program that will loop through the values between 1 and 100 and display what kind of blast
//   the crew should expect. (The % operator may be of use.)
// • Change the color of the output based on the type of blast. (For example, red for Fire, yellow for
//   Electric, and blue for Electric and Fire).

//int maximumNumberOfCannonCranks = 500;
//int numberOfCurrentCannonCranks = 0;

//for (numberOfCurrentCannonCranks = 1; numberOfCurrentCannonCranks <= maximumNumberOfCannonCranks; numberOfCurrentCannonCranks++)
//{
//    int remainingCannonCranks = maximumNumberOfCannonCranks - numberOfCurrentCannonCranks;
//    if (remainingCannonCranks > 0)
//    {
//        if (numberOfCurrentCannonCranks != 0 && numberOfCurrentCannonCranks % 100 == 0)
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.WriteLine($"{numberOfCurrentCannonCranks}: POISON CUM BLAST activated!");
//        }
//        else if (numberOfCurrentCannonCranks != 0 && numberOfCurrentCannonCranks % 3 == 0 && numberOfCurrentCannonCranks % 5 == 0)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine($"{numberOfCurrentCannonCranks}: ELECTROFIRE!");
//        }
//        else if (numberOfCurrentCannonCranks != 0 && numberOfCurrentCannonCranks % 3 == 0)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine($"{numberOfCurrentCannonCranks}: Fire gem activated");
//        }
//        else if (numberOfCurrentCannonCranks != 0 && numberOfCurrentCannonCranks % 5 == 0)
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine($"{numberOfCurrentCannonCranks}: Electric gem activated");
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine($"The cannon has {remainingCannonCranks} cranks remaining.");
//        }
//    }
//}

//Console.BackgroundColor = ConsoleColor.Red;
//Console.ForegroundColor = ConsoleColor.White;
//Console.Beep();
//Console.WriteLine($"Cannon cannot crank any more! Cannon's limit of {maximumNumberOfCannonCranks} has been reached!");
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ARRAYS

// int[] scores = new int[10]; // The `new` keyword makes new things in your program. Stuff like `int`, `bool`, and `string` have built-in ways to make new values, such
// as `3`, `true`, or `"Hello, World!"`, but some of the more complex types, like arrays, must use the keyword `new` to make new values.

// Once an array value has been set, it cannot be changed. To change the value of scores, a new array must be made using the same variable:

// scores = new int[20];

// The scores variable now moves over to use the memory of this array, and forgets the old one. The old data is still in the old array, though, and we would need to
// copy it over. This will be learned about in Level 32, when we make lists, which are a much more powerful tool than arrays. But lists build on top of arrays, so
// arrays are still important to learn.

// GETTING AND SETTING VALUES IN ARRAYS
// How to work with specific items in an array? Use the INDEXER OPERATOR ([ and ]). This example code assigns a value to spot #0 in the scores array:

// scores[0] = 99;

// The number in brackets is called the INDEX. The code above stores the value 99 into scores at index 0. You can also do this with an int expression:

// scores[index + 1]

// In C#, ***indexing starts at zero (0) instead of one (1).*** This is the same in C++, C, and Java. Not all languages work this way, but many do.
// This is called 0-BASED INDEXING.
// Other values in the array can be accessed with other indexes:

// scores[1] = 95;
// scores[2] = 84;

// You can even use the indexer operator [] to read the current value in an array at a specific index:

// Console.WriteLine(scores[1]); // This writes out the current value of the first (0th index) element in the scores array.

// Default Values
// When a new array is made, the computer will take the array's memory location and set every bit to 0. This initializes every spot to 0 for numeric types; false for
// the bool type; a `null character` for the character type; and a `null` for the string type. More on the null stuff later.

// If the default value is good enough, we don't need to populate an entire array with values:

// int[] scores = new int[5];

// This array will contain 5 spots (index 0, 1, 2, 3, and 4) each with a default value of 0.

// Crossing Array Bounds
// Attempting to access an index beyond the reach of its size can lead to dangerous things. C# makes sure to stop the computer from trying to reach beyond the start
// or end of an array, creating an index out-of-range error that will crash your program if not addressed. See below:

// int[] scores = new int[5];   // System.IndexOutOfRangeException: 
// scores[10] = 1000;           // 'Index was outside the bounds of the array.'

// Since scores only has 5 items, trying to access anything below index 0 or above index 4 would fail. Luckily, each array remembers how long it is. This can be
// accessed with the array's Length variable (technically a property, more on that later):

// Console.WriteLine(scores.Length);
// This is especially useful when you don't know how long an array might be. The code below asks a user for a length, creates an array of that size, then uses a FOR
// loop to fill in the values:

// int length = Convert.ToInt32(Console.ReadLine()); // takes the user's input for the length of the array
// int[] array = new int[length]; // creates a new array using the length the user specified

// for (int index = 0; index < array.Length; index++) // starts index at 0, checks each loop to make sure it's less than the length of the array, then increments it by
// {                                                  // 1 until it's at the value of the array
//     array[index] = 1; // at each index of the array, its value is set to 1.
// }
// this will produce an array full of 1's, with as many elements as the user asked for.
// FOR loops are commonly used with arrays. The scheme above is typical and worth noting when you need to do it yourself. Most C# programmers will start the index
// at 0, loop as long as the loop's variable is less than the array's length, and increment the variable each time through the loop.

// Indexing from the End
// Sometimes you want to start by getting items from the back of the array instead of the front. You can use the (^) operator to do this, as in the code below:

// int lastPlaceScore = scores[^1];

// ***From the front, you start at 0, but from the back, you start at 1.***

// Ranges
// You can also grab a copy of a section or range within an array by using the range operator (..):

// int[] firstThreeScores = scores[0..3];

// With arrays, this makes a copy. Changing firstThreeScores won't affect the original scores array.

// The first number in the range is the index to start at, and the second number is the index to end at, but ***the second number is NOT INCLUDED in the copy.***
// This means that for scores[0..3], it will grab the elements that are at 0, 1, and 2, but not at 3.

// These numbers can be any INT expression, and you can use (^) to index from the back. This code makes a copy of the array excluding the first and last items:

// int[] theMiddle = scores[1..^1];

// However, if your endpoint is before your start point, the program will crash. Make sure this doesn't happen.

// You can also leave off either end (or both ends) to use a default of the array's start or end. For example, scores[2..] makes a copy of the entire array
// except for the first two elements.

// OTHER WAYS TO CREATE ARRAYS
// Doing something like new int[10] is a common way to create new arrays, but variations exist. If you know what values you want in your array, you can do this:

// int[] scores = new int[10] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

// This is called the COLLECTION INITIALIZER SYNTAX. The number of items and the length must match. If you list all of the items, though, you can remove the length:

// int[] scores = new int[] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

// Also, if the type of values listed is clear enough for the compiler to understand and infer the type, you don't even need to specify the type when you make it:

// int[] scores = new [] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

// SOME EXAMPLES WITH ARRAYS
// This first example calculates the minimum value in an array. We hang on to the smallest number we've found so far and work our way through the array looking at each
// item. For each item, we check to see if it's smaller than the current smallest number we've found, and if so, use that as our new smallest number. When we reach the
// end of the array, we know the item we've set aside is the smallest in the entire array.

// int[] array = new [] { -95, 47, 28, 84, 1094, 721, -6, -405, 69, 82, 81, 101, -606, 507 };

// int currentSmallestNumber = int.MaxValue; // This makes sure to start the number at the highest possible number so that everything in the array is smaller than it.
// for (int index = 0; index < array.Length; index++) // This loops through the array, starting at 0 and ending at the array's Length, as always.
// {
//    if (array[index] < currentSmallestNumber) // This checks to see if the value of the index we're checking is less than currentSmallestNumber, and if it is, it sets
//    {                                         // currentSmallestNumber to the value of the index we're checking.
//        currentSmallestNumber = array[index];
//    }
// }
// Console.WriteLine(currentSmallestNumber);

// This next example calculates the average of the numbers in an array. The average value is the total of all items in the array, divided by the number of items it has.
// We can find the sum of all items in the array by keeping a running total, starting at 0, and adding each item to the total as we iterate across them in the loop.
// Once we finish that, we computer the average by taking the total and dividing it by the number of items in the array:

// int[] array = new int[] { 91, 2, 898, -78, -71, -4, 2, 49, 571, 80, 10 };
// 
// int total = 0;
// for(int index = 0; index < array.Length; index++) // as usual, this loops through the items in the array until we reach the array's length.
//     total += array[index]; // each loop, this increases the total by the value of the current item in the array, starting at index 0, and ending at the array's length.
// 
// int average = total / array.Length; // this calculates the average of the values of the numbers in the array, and produces a result as a whole number (rounded down).
// Console.WriteLine(average); // this displays the average of the items in the array in the Console window.

// Level 12 Challenge: The Replicator of D'To (100 XP)

// While searching an abandoned storage building containing strange code artifacts, you uncover the ancient Replicator of D’To. This can replicate the contents of any int
// array into another array. But it appears broken and needs a Programmer to reforge the magic that allows it to replicate once again.
// Objectives:
// • Make a program that creates an array of length 5.
// • Ask the user for five numbers and put them in the array.
// • Make a second array of length 5.
// • Use a loop to copy the values out of the original array and into the new one.
// • Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works again.

// int[] firstArray = new int[5]; // this initializes a new array with a length of 5
// 
// for (int index = 0; index < firstArray.Length; index++) // this loops over all 5 items in the array
// {
//     Console.Write("Please give me a number to be put in an array: ");
//     firstArray[index] = Convert.ToInt32(Console.ReadLine()); // this takes the current item in the array and assigns it a value according to the user's input
// }
// 
// int[] secondArray = new int[5]; // this initializes a second new array with a length of 5 so that the first array's values can be copied over to it
// 
// for (int index = 0; index < secondArray.Length; index++) // this loops over all 5 items in the second array
//     secondArray[index] = firstArray[index]; // this takes the current item in the second array and assigns it the value of the first array's item at the same index
// 
// for (int index = 0; index < secondArray.Length; index++) // this loops over all 5 items in the array
// {
//     Console.WriteLine($"Copying {firstArray[index]} to {secondArray[index]}"); // this displays the values of both arrays' indexes to show it's copying the right ones
// }
// 

// THE FOREACH LOOP

// Arrays and loops often go together because doing something with each item in an array is common. For example, this displays all items in an array:
// int[] ints = new int[10]; // this initializes a new array of ints with a length of 10
// for (int i = 0; i < ints.Length; i++) // this loops over all items in the array
// {
//     ints[i] = i; // this sets the value of the current item in the array to the value of its index (i.e. index 1 is given a value of 0, index 2 is given a value of 1)
//     Console.WriteLine(ints[i]); // this displays each item in the array
// }
//     

// The fourth and final loop type in C# is the FOREACH loop. It's designed for the same scenario as above, but has a simpler syntax than a FOR loop. The code above
// would then look like this when made into a FOREACH loop:

// int[] scores = new int[10];
// 
// foreach(int score in scores) // with a FOREACH loop, you declare the variable you want to represent each item `in` the array you want to iterate over. the keyword `in`
//                              // separates the variable from the array you want to iterate over. the variable can then be used in the loop.
// {
//     Console.WriteLine(score); // each loop, this displays the value of the current item in the scores array
// }

// The downside to the FOREACH loop is that you lose knowledge about which index you are at--something a FOR loop makes clear with its variable. If you want to access
// both the item and its index (e.g. to display "Score #3 is 82"), it's best to use a FOR loop.

// A FOREACH loop is usually easier to read than a FOR loop, but it runs more slowly than a FOR loop. If performance becomes a problem, you can rewrite a FOREACH loop
// into a FOR loop to save on performance costs.

// Level 12 Challenge: The Laws of Freach (50 XP)
// The town of Freach recently had an awful looping disaster. The lead investigator found that it was a faulty
// ++ operator in an old for loop, but the town council has chosen to ban all loops but the foreach loop.
// Yet Freach uses the code presented earlier in this level to compute the minimum and the average value
// in an int array. They have hired you to rework their existing for-based code to use foreach loops
// instead.
//
// Objectives:
// • Start with the code for computing an array’s minimum and average values in the section Some Examples with Arrays, starting on page 94.
// • Modify the code to use foreach loops instead of for loops.

// EXAMPLE 1

// int[] smellyNumbers = new [] { -95, 47, 28, 84, 1094, 721, -6, -405, 69, 82, 81, 101, -606, 507 };
// 
// int currentSmallestNumber = int.MaxValue; // This makes sure to start the number at the highest possible number so that everything in the array is smaller than it.
// foreach (int smellyNumber in smellyNumbers) // This loops through the array, starting at 0 and ending at the array's Length, as always.
//     if(currentSmallestNumber > smellyNumber)
//         currentSmallestNumber = smellyNumber;
// 
// Console.WriteLine(currentSmallestNumber);
// 

// EXAMPLE 2

// 
// int[] niceNumbers = new int[10] { 91, 2, 898, -78, -71, -4, 2, 49, 571, 80 };
// 
// int total = 0;
// foreach (int niceNumber in niceNumbers)
//     total += niceNumber;
// 
// int average = total / niceNumbers.Length; // this calculates the average of the values of the numbers in the array, and produces a result as a whole number (rounded down).
// Console.WriteLine(average); // this displays the average of the items in the array in the Console window.

// MULTI-DIMENSIONAL ARRAYS | My own take on them
// So far, every array we have created has been single-dimensional, meaning the array only represents one collection of elements, whether it be bools, chars, doubles,
// floats, ints, or even arrays themselves! An array of arrays is called a multi-dimensional array. With multi-dimensional arrays, we can represent multiple collections
// of elements. A two-dimensional array, for example, consists of single-dimensional arrays (like the bool[], int[], and string[] array types) as its elements. It's easy
// to look at multi-dimensional arrays by looking at a table featuring rows and columns, like this:

// [][][][][]
// [][][][][]
// [][][][][]

// In this table, we have 3 rows and 5 columns, the rows representing how many elements the `parent` array holds, and the columns representing how many elements are
// in each of those `child` arrays. I'll be referring to these as parents and children from this point forward, because it makes it easier for me to understand.

// Declaring Two-Dimensional Arrays
// Like with single-dimensional arrays, a two-dimensional array can be declared by initializing it as a new int array, with two elements: the number of elements in the
// parent array, and the number of elements in the child arrays, as shown below:

// int[,] arrays2D = new int[2, 3]; // To show that we're declaring a two-dimensional array, we must put a comma in the brackets.

// This code above shows that it is a two-dimensional array with 2 elements, or 2 child arrays. Each of those child arrays (the 2 elements of the parent array) has
// 3 elements in them. So all together, the array can store 6 total elements (2 * 3).

// Initializing Two-Dimensional Arrays
// Just as with single-dimensional arrays, initializing the child arrays works the same way. We can specify what values we want each of the child arrays' elements to be.
// And just like with other array types, we don't need to specify that we are making a "new int[,]", as the compiler will understand through context that we are making
// an array of arrays. However, it's still good practice (in my opinion) to specify, just for clarity's sake:

// int[,] arrays2D = { { 1, 2, 3 }, { 4, 5, 6 } }; // This creates a 2D array with 2 elements, each of which contain 3 specific elements with the values 1-3, and 4-6.

// We can also specify the number of arrays for clarity's sake as well, and to make sure that we fill each array with the same number of elements (this is required):

// int[,] arrays2D = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; // Here, if we were to only assign a value to two elements in the first array, we'd get an error. This is
// because we specified that there are 2 arrays, each of which contain 3 elements.

// Accessing two-dimensional arrays works the same, too. The only differences they have two indexes! Surprised? You shouldn't be! It makes it easy to remember:

// int[,] arrays2D = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; // the 2D array from above

// how to access the `parent` array's first element (its first `child` array), and access that first `child` array's first element, 1.
/* 
 Console.WriteLine("Child array 1 (at index 0) and its first element (at index 0): " + 
    arrays2D[0, 0]); // we access index 0 of the `parent` array to get the first element {1,2,3}, and index 0 of that array to get its first element, 1.

// how to access the `parent` array's second element (its second `child` array), and access that second `child` array's third element, 6.
Console.WriteLine("Child array 2 (at index 1) and its third element (at index 2): " +
    arrays2D[1, 2]); // we access index 1 of the `parent` array to get the second element {4,5,6}, and index 2 of that array to get its third element, 6. */