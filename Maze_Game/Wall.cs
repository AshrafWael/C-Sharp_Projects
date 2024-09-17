﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class Wall : IMazeObject
    {
        public char Icon 
        {
            get => '#';
        }
        public bool IsVisible {
            get => true; 
        }
    }
}
