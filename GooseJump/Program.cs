using GooseJump;


var map = new Map();
var player = new Goose(map.Width / 5);

map.Setup();

Console.CursorVisible = false;
bool gameOver = false;

while (!gameOver)
{
    Console.Clear();
    map.Draw();
    var mapPos = map.GetMapPos();
    player.Draw(mapPos);

    while(Console.KeyAvailable)
    {
         var key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.Spacebar)
            player.Jump(3);

        if (key.Key == ConsoleKey.A)
            player.MoveLeft();

        if (key.Key == ConsoleKey.D)
            player.MoveRight();

    }

    player.CalculateNextPosition();
    Thread.Sleep(20);
    map.Move();

    foreach (Obstacle obstacle in map.Obstacles)
    {
        if (Model.CheckCollision(player, obstacle)){
            gameOver = true;

        }

    }
}



Console.WriteLine("\n\n\n\n\n\n");
Console.WriteLine("GAME OVER!");
