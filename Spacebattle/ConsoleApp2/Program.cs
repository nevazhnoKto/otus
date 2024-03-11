using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<SpaceObject> listSpaceObject = new List<SpaceObject>()
            {
                new SpaceShipClass(0, 1),
                new SpaceShipClass(1, 1),
                new SpaceShipClass(2, 2),
                new SpaceShipClass(3, 2)
            };
            var spaceships = listSpaceObject.Spaceships(1);
            var spaceship = listSpaceObject.Spaceship(2);
            var objectIsMovable = listSpaceObject.Movable();
        }

        static IEnumerable<SpaceObject> Spaceships(this IEnumerable<SpaceObject> spaceObject, int idPlayer)
        {
            return spaceObject.Where(so => so.IdPlayer == idPlayer && so.SpaceObjectType == SpaceObjectTypeEnum.Spaceship);
        }

        static SpaceObject Spaceship(this IEnumerable<SpaceObject> spaceObject, int id)
        {
            return spaceObject.First(so => so.Id == id);
        }

        static IEnumerable<SpaceObject> Movable(this IEnumerable<SpaceObject> spaceObject)
        {
            return spaceObject.Where(so => so.Movable);
        }

    }
}