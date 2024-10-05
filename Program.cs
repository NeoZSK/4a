using GooseJump;


var map = new Map();
var player = new Goose(map.Width / 5);


while (true)
{
    map.Draw();
    player.Draw();

    if(Console.KeyAvailable)
    {
        var key = Console.ReadKey();
        if(key.Key == ConsoleKey.W)
        {
            Console.WriteLine("JUMP");
            player.Jump(2);
        }
    }

    Thread.Sleep(100);
    Console.Clear();
    player.Move();
}


