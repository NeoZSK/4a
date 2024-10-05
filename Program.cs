using GooseJump;


var map = new Map();
var player = new Goose(map.Width / 5);

map.Setup();

Console.CursorVisible = false;
while (true)
{
    Console.Clear();
    map.Draw();
    var drawingStart = map.GetDrawingStartCoords();
    player.Draw(drawingStart);

    while(Console.KeyAvailable)
    {
        var key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.W)
            player.Jump(2);

        if (key.Key == ConsoleKey.A)
            player.MoveLeft();

        if (key.Key == ConsoleKey.D)
            player.MoveRight();

        player.Draw(drawingStart);

    }
    player.CalculateNextPosition();


    Thread.Sleep(20);


    //map.Move();

}




