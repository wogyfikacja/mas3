using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mas3
{
    public class Laboratory : IRoom
    {
        public int RoomNumber { get; private set; }
        public int Area { get; private set; }
        public Dictionary<String, int> Equipment {get; private set;}
        public Laboratory(int roomNumber, int area,  Dictionary<String, int> equipment)
        {
            RoomNumber = roomNumber;
            Area = area;
            Equipment = equipment;
        }
        public Laboratory(IRoom room, Dictionary<String, int> equipment)
        {
            RoomNumber = room.RoomNumber;
            Area = room.Area;
            Equipment = equipment;
        }
        public override string ToString()
        {
            return $"Laboratory: {RoomNumber}, {Area}, {Equipment}";
        }
    }
}