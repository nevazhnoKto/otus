using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface SpaceObject
    {
        public int Id { get; set; }
        public bool Movable { get; set; }
        public int? IdPlayer { get; set; }
        public SpaceObjectTypeEnum SpaceObjectType { get; set; }
    }
}
