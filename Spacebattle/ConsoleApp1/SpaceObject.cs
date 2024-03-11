using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface SpaceObject
    {
        public int Id { get; set; }
        public int IdPlayer { get; set; }
        public bool Movable { get; set; }
    }
}
