using CommonLibs;
using HotelManager.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DataAccess.DAL
{
    public interface IRoomManger
    {
        List<Room> GetRooms();
        ReturnData AddRoom(Room _Room, string _RoomNumber, string _RoomType, string _RoomName);
        ReturnData RemoveRoom(Room _Room, string _RoomNumber, string _RoomType, string _RoomName);
        ReturnData UpdateRoom(Room _Room, string _RoomNumber, string _RoomType, string _RoomName);
    }
}
    