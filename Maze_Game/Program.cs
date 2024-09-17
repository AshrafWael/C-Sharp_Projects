namespace Maze_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze(40, 20);
            while (true)
            {
                maze.DrowMaze();
                maze.MovePlayer();
            }


        }
    }
}
