using CommonLibs;
using HotelManager.DataAccess.DAL;
using HotelManager.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DataAccess.DALImpl
{
    public class IRoomManagerImpl : IRoomManger
    {
        private List<Room> rooms = new List<Room>();

        //Hiển thị danh sách phòng

        List<Room> IRoomManger.GetRooms()
        {
            return rooms;
        }
        //Tạo phòng mới
        public void AddNewRoom()
        { }
        public ReturnData AddRoom(Room _Room, string _RoomNumber, string _RoomType, string _RoomName)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                if (!ValidateData.CheckIsNullOrWhiteSpace(_RoomNumber) || !ValidateData.OutputNumbers(_RoomNumber, out int roomNumber) || roomNumber < 0)
                {
                    //Kiểm tra phòng có tồn tại hay không
                    bool roomExists = rooms.Any(r => r.RoomNumber == _Room.RoomNumber);
                    if (!roomExists)
                    {
                        returnData.ReturnCode = -1;
                        returnData.ReturnMsg = "Số phòng không hợp lệ!";
                        return returnData;
                    }
                }
                else
                { 
                    _Room.RoomNumber = roomNumber; 
                }

                if (!ValidateData.CheckIsNullOrWhiteSpace(_RoomType) || !ValidateData.OutputNumbers(_RoomType, out int roomtTypes) || roomtTypes < 0 || roomtTypes > 6)
                {
                    returnData.ReturnCode = -2;
                    returnData.ReturnMsg = "Loại phòng không hợp lệ!";
                    return returnData;
                }
                else
                {
                    _Room.RoomType.Types = roomtTypes;
                }
                

                if (!ValidateData.CheckIsNullOrWhiteSpace(_RoomName) || !ValidateData.ContainsNumber(_RoomName)
                    || !ValidateData.CheckContainSpecialChar(_RoomName) || !ValidateData.CheckXSSInput(_RoomName))
                {
                    returnData.ReturnCode = -3;
                    returnData.ReturnMsg = "Loại phòng không hợp lệ!";
                    return returnData;
                }
                else
                {
                    _Room.RoomType.Name = _RoomName;
                }    
                
                _Room.IsAvailable = true;
                rooms.Add(_Room);

                returnData.ReturnCode = 1;
                returnData.ReturnMsg = "Thêm phòng thành công!";
                return returnData;

            }
            catch (Exception ex)
            { 
               throw;
            }
        }

        //Xóa phòng
        ReturnData IRoomManger.RemoveRoom(Room _Room, string _RoomNumber, string _RoomType, string _RoomName)
        {
            throw new NotImplementedException();
        }

        
        //Chỉnh sửa thông tin phòng
        ReturnData IRoomManger.UpdateRoom(Room _Room, string _RoomNumber, string _RoomType, string _RoomName)
        {
            throw new NotImplementedException();
        }
    }
}
