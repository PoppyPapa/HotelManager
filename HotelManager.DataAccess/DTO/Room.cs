using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DataAccess.DTO
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; }
    }
}
