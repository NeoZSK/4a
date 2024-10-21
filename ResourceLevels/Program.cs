Random random = new Random();
int oxygenLevel = 100;
int waterLevel = 100;
int energyLevel = 100;

bool gameOver = false;
int hour = 0;
int tick = 0;

// ctrl + k, ctrl + d
// alt + arrow up/down
// ctrl + r, ctrl + r
// ctrl + arrows
// ctrl + shift + arrows
// ctrl + l
// ctrl + home/end
// alt + shift + arrow up/down

while (!gameOver)
{
    tick++;
    if (tick % 10 == 0)
    {
        hour++;
        oxygenLevel -= random.Next(5, 21);  // Losowy spadek poziomu tlenu
        waterLevel -= random.Next(5, 21);   // Losowy spadek poziomu wody
        energyLevel -= random.Next(5, 21);  // Losowy spadek poziomu energii


        PrintInterface(hour, oxygenLevel, waterLevel, energyLevel);

        if (oxygenLevel < 50 || waterLevel < 50 || energyLevel < 50)
        {
            if (oxygenLevel <= 0 || waterLevel <= 0 || energyLevel <= 0)
            {
                gameOver = true;
            }
            else
            {
                Console.WriteLine("ALERT: Resource levels below 50%!");
            }
        }
    }




    while (Console.KeyAvailable)
    {
        var k = Console.ReadKey();
        if (k.Key == ConsoleKey.O)
        {
            oxygenLevel += 20;
            PrintInterface(hour, oxygenLevel, waterLevel, energyLevel);
        }


        if (k.Key == ConsoleKey.W)
        {
            waterLevel += 20;
            PrintInterface(hour, oxygenLevel, waterLevel, energyLevel);
        }

        if (k.Key == ConsoleKey.E)
        {
            energyLevel += 20;
            PrintInterface(hour, oxygenLevel, waterLevel, energyLevel);
        }

    }



    Thread.Sleep(100);
}

Console.WriteLine("Resource levels reached 0%");
Console.WriteLine("Game over!");



void PrintInterface(int hour, int oxygenLevel, int waterLevel, int energyLevel)
{
    Console.Clear();
    Console.WriteLine($"Hour {hour}: Oxygen: {oxygenLevel}%, Water: {waterLevel}%, Energy: {energyLevel}%");

}