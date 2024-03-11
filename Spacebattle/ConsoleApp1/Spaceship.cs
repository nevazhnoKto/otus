using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Spaceship : SpaceObject
    {
        public Spaceship(int id, int idPlayer, bool movable)
        {
            Id = id;
            IdPlayer = idPlayer;
        }

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IdPlayer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Movable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
