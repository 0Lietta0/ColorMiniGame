using System.Drawing;

//-introduce game to the user

Console.WriteLine("Hi there and welcome to the Color Mini-Game!\n");
Console.WriteLine("Rules are simple: You will see a color block and than write down the color name.");
Console.WriteLine("If you do it properly then you will win and if you don't ... you lose.\n");
Console.WriteLine("Press enter to start the game");
Console.ReadLine();
Console.Clear();

//-display random color

Console.WriteLine("Now you see a block of color on the screen.\n");

ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
Random random = new Random();

int randomColorNumber = random.Next(9, colors.Length - 1);
ConsoleColor randomColor = colors[randomColorNumber];

Console.ForegroundColor = ConsoleColor.Black;
Console.Write("{0,10}", "a");
Console.BackgroundColor = randomColor;
Console.ForegroundColor = randomColor;
Console.WriteLine("{0,10}", "-----");
Console.ResetColor();

//-ask user to name the color

Console.Write("\nIt might be: ");
for (int i = 9; i < colors.Length; i++)
{
    Console.Write($"{colors[i]} ");
}
Console.WriteLine("\n");
Console.Write("Write the name of the color you see to win: ");
string? readResult = Console.ReadLine();

//-display win or lose message

if (readResult != null)
    readResult = readResult.Trim().ToLower();
string correctColor = randomColor.ToString().Trim().ToLower();

Console.WriteLine();

if (readResult == correctColor)
{
    Console.WriteLine("You win!");
}
else
    Console.WriteLine("You lose!");

Console.ReadLine();