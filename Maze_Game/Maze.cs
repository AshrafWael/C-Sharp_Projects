using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class Maze
    {
        private int _width { get; set; }
        private int _height { get; set; }
        private Player _Player;
        private IMazeObject[,] _mazeObjectsArray;
        
        
        public Maze(int width, int hight)
        {
            _width = width;
            _height = hight; 
            _mazeObjectsArray = new IMazeObject[width,hight];
            _Player = new Player 
            {
            X = 1,  
            Y = 1,
            };
        }
        public void DrowMaze()
        {
            Console.Clear();

            for(int  y= 0; y < _height;y++)
            {
                for (int x = 0;x < _width;  x++)
                {
                    //casting  _mazeObjectsArray to new wall concret class object 
                    // casting from interface object to class object

                     if (x == 0 || y == 0 || x == _width - 1 || y == _height - 1)//outer Walls
                    {
                        _mazeObjectsArray[x, y] = new Wall();
                        Console.Write(_mazeObjectsArray[x, y].Icon);
                    }
                   else if ( x == _width-2 && y == _height-1) //Exit
                    {
                        _mazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(_mazeObjectsArray[x, y].Icon);
                    }
                    else if (x %3 == 0 && y%3 ==0)
                    {
                        _mazeObjectsArray[x, y] = new Wall();
                        Console.Write(_mazeObjectsArray[x, y].Icon);
                    }
                    else if (x % 5 == 0 && y % 8 == 0)
                    {
                        _mazeObjectsArray[x, y] = new Wall();
                        Console.Write(_mazeObjectsArray[x, y].Icon);
                    }
                    else if (x == _Player.X && y == _Player.Y) //player
                    {
                        Console.Write(_Player.Icon);
                    }
                    else //Empty Spaces
                    {
                        _mazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(_mazeObjectsArray[x, y].Icon);
                    }

                }
                Console.WriteLine();
            }
        }
        public void MovePlayer()
        { 
            //return user input key info
             ConsoleKeyInfo UsereInput =Console.ReadKey(); 
             ConsoleKey Key = UsereInput.Key;
            switch (Key)
            {


            case ConsoleKey.UpArrow:
                    {
                        UpdatePlayerPosition(0,-1);
                    }
                    break;
            case ConsoleKey.DownArrow:
                    {
                        UpdatePlayerPosition(0, 1);
                    }
                break;
            case ConsoleKey.LeftArrow:
                    {
                        UpdatePlayerPosition(-1, 0);
                    }
                break;
            case ConsoleKey.RightArrow:
                    {
                        UpdatePlayerPosition(1, 0);
                    }
                break;

            }
        
        
        }
        public void UpdatePlayerPosition(int dx,int dy)
        {
            int newXPosition = _Player.X + dx;
            int newYPosition = _Player.Y + dy;

            if (newXPosition < _width && newXPosition >=0 && newYPosition >=0 && newYPosition < _height && _mazeObjectsArray[newXPosition,newYPosition].IsVisible ==false)
            {
                _Player.X = newXPosition;
                _Player.Y = newYPosition;
                DrowMaze();
            }
        }

    }
}
