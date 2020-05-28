using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace Final_Exam
{
    public class Room
    {
        public string roomName;
        public string nextRoom;
        public string pathWay;
        public int roomId;
        public string RoomName
        {
            get
            {
                return roomName;
            }
            set
            {
                this.roomName = value;
            }
        }
        public string NextRoom
        {
            get
            {
                return nextRoom;
            }
            set
            {
                this.nextRoom = value;
            }
        }
        public string PathWay
        {
            get
            {
                return pathWay;
            }
            set
            {
                this.pathWay = value;
            }
        }
        public int RoomId
        {
            get
            {
                return roomId;
            }
            set
            {
                this.roomId = value;
            }
        }
        public Room (string roomName, string nextRoom, string pathWay, int roomId)
        {
              this.RoomName = roomName;
              this.NextRoom = nextRoom;
              this.PathWay = pathWay;
              this.RoomId = roomId;
        }

    }
}
