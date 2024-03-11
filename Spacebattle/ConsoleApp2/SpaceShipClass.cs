using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SpaceShipClass : SpaceObject
    {
        public int Id { get; set; }
        public bool Movable { get; set; }
        public int? IdPlayer { get; set; }
        public SpaceObjectTypeEnum SpaceObjectType { get; set; }
        public SpaceShipClass(int id, int idPlayer)
        {
            Id = id;
            IdPlayer = idPlayer;
            Movable = false;
            SpaceObjectType = SpaceObjectTypeEnum.Spaceship;
        }
    }
}
