using static System.Net.Mime.MediaTypeNames;
Arrow GetArrow()
{
        Console.WriteLine("Create a custom arrow or choose from three predefined arrows: \n" +
                  "1. Beginner arrow \n" +
                  "2. Marksman arrow \n" +
                  "3. Elite arrow \n" +
                  "4. Custom arrow");

        int userChoice = GetUserResponse();

        return userChoice switch
        {
                1 => Arrow.CreateBeginnerArrow(),
                2 => Arrow.CreateMarksmanArrow(),
                3 => Arrow.CreateEliteArrow(),
                4 => CreateCustomArrow(),
                _ => throw new NotImplementedException("Invalid arrow selection.")
        };
}

Arrow arrow = GetArrow();
GetCost(arrow);

Arrow CreateCustomArrow()
{
        Arrowhead arrowhead = GetArrowhead();
        decimal shaftLength = GetShaftLength();
        decimal shaftWidth = GetShaftWidth();
        Fletching fletching = GetFletching();

        return new Arrow(arrowhead, shaftLength, shaftWidth, fletching);
}

Arrowhead GetArrowhead()
{
        Console.WriteLine($"Arrowhead types: \n" +
        $"1. {Arrowhead.Steel} \n" +
        $"2. {Arrowhead.Obsidian} \n" +
        $"3. {Arrowhead.Wood}");
        Console.Write("Choose your arrowhead type: ");

        int userChoice = GetUserResponse();

        return userChoice switch
        {
                1 => Arrowhead.Steel,
                2 => Arrowhead.Obsidian,
                3 => Arrowhead.Wood,
                _ => throw new NotImplementedException("Invalid arrowhead selection.")
        };
}

decimal GetShaftLength()
{
        decimal shaftLength = AskForNumberInRange("Choose a shaft length between 60cm and 100cm: ", 60, 100);
        return shaftLength;
}

decimal GetShaftWidth()
{
        decimal shaftWidth = AskForNumberInRange("Choose a shaft width between 1cm and 3cm: ", 1, 3);
        return shaftWidth;
}

Fletching GetFletching()
{
        Console.WriteLine($"Fletching types: \n" +
        $"1. {Fletching.EagleFeathers} \n" +
        $"2. {Fletching.GooseFeathers} \n" +
        $"3. {Fletching.TurkeyFeathers}");
        Console.Write("Choose your fletching type: ");

        int userChoice = GetUserResponse();

        return userChoice switch
        {
                1 => Fletching.EagleFeathers,
                2 => Fletching.GooseFeathers,
                3 => Fletching.TurkeyFeathers,
                _ => throw new NotImplementedException("Invalid fletching selection.")
        };
}

decimal GetCost(Arrow arrow)
{
        decimal arrowheadCost = 0;
        decimal shaftCost = (arrow.ShaftWidth * 0.00752m) + (arrow.ShaftLength * 0.034521m);
        decimal fletchingCost = 0;

        arrowheadCost = arrow.Arrowhead switch
        {
                Arrowhead.Obsidian => 5,
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                _ => throw new NotImplementedException()
        };

        fletchingCost = arrow.Fletching switch
        {
                Fletching.EagleFeathers => 10,
                Fletching.GooseFeathers => 3,
                Fletching.TurkeyFeathers => 5,
                _ => throw new NotImplementedException()
        };

        decimal totalArrowCost = Math.Round(Convert.ToDecimal(arrowheadCost + shaftCost + fletchingCost), 2);

        Console.WriteLine($"Your arrow will cost you $GP {totalArrowCost}.");

        return totalArrowCost;
}

int GetUserResponse()
{
        return Convert.ToInt32(Console.ReadLine());
}
int AskForNumber(string text)
{
        while (true)
        {
                Console.WriteLine(text);

                if (int.TryParse(Console.ReadLine(), out int userChoice))
                        return userChoice;

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

                Console.WriteLine($"Sorry, the number {number} is invalid. Please enter a number between {min} and {max} and try again.");
        }
}

class Arrow
{
        public Arrowhead Arrowhead { get; }
        public decimal ShaftLength { get; }
        public decimal ShaftWidth { get; }
        public Fletching Fletching { get; }

        public Arrow()
        {
                Arrowhead = Arrowhead.Wood;
                ShaftLength = 60;
                ShaftWidth = 1;
                Fletching = Fletching.TurkeyFeathers;
        }

        public Arrow(Arrowhead arrowhead, decimal shaftLength, decimal shaftWidth, Fletching fletching)
        {
                Arrowhead = arrowhead;
                ShaftLength = shaftLength;
                ShaftWidth = shaftWidth;
                Fletching = fletching;
        }

        public static Arrow CreateBeginnerArrow()
        {
                return new Arrow(Arrowhead.Wood, 60, 1, Fletching.GooseFeathers);
        }

        public static Arrow CreateMarksmanArrow()
        {
                return new Arrow(Arrowhead.Steel, 80, 2, Fletching.TurkeyFeathers);
        }

        public static Arrow CreateEliteArrow()
        {
                return new Arrow(Arrowhead.Obsidian, 100, 3, Fletching.EagleFeathers);
        }
}

enum Arrowhead
{
        Obsidian,
        Steel,
        Wood
};

enum Fletching
{
        EagleFeathers,
        GooseFeathers,
        TurkeyFeathers,
};