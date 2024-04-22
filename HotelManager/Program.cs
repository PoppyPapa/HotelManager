using CommonLibs;
using HotelManager.DataAccess.DALImpl;
using HotelManager.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    partial class Program
    {
        public void Main(string[] args)
        {
            List<Room> lstrooms = new List<Room>();

            IRoomManagerImpl roomManager = new IRoomManagerImpl();
            var room1 = new HotelManager.DataAccess.DTO.Room();


             roomManager.AddRoom(room1, "1", "2", "Love");
        }
    }
}
