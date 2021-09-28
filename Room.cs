using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Room
    {
        private string floorNumber;
        public string FloorNumber
        {
            get { return floorNumber; }
            set { floorNumber = value; }
        }

        private string roomNumber;
        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public Room(string aFloorNumber, string aRoomNumber)
        {
            FloorNumber = aFloorNumber;
            RoomNumber = aRoomNumber;
        }
    }
}
