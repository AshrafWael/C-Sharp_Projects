using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public interface IMazeObject
    {
        // the chap of the maze (empty place ,solid Place ,charechter)
        public char Icon { get; }
        // the movement Block
        public bool IsVisible { get;} 
    }
}
