using GooseJump;


var map = new Map();
var player = new Goose(map.Width / 5);


while (true)
{
    map.Draw();
    player.Draw();

    while (Console.KeyAvailable)
    {
        var key = Console.ReadKey(false);
        if (key.Key == ConsoleKey.W)
        {
            player.Jump(2);
        }
    }

    Thread.Sleep(50);
    Console.Clear();

    player.Move();
    map.Move();
}


