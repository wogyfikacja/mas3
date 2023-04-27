using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mas3
{
    public class Storage : IRoom
    {
        public int RoomNumber { get; private set; }

        public int Area { get; private set; }
        public Dictionary<string, int> substances { get; private set; }
        public Storage(int roomNumber, int area,  Dictionary<string, int> substances)
        {
            RoomNumber = roomNumber;
            Area = area;
            this.substances = substances;
        }
        public Storage(IRoom room,  Dictionary<string, int> substances)
        {
            RoomNumber = room.RoomNumber;
            Area = room.Area;
            this.substances = substances;
        }
        public override string ToString()
        {
            return $"Storage: {RoomNumber} {Area} {substances}";
        }
    }
}