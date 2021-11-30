using DAL.User;
using DataObjects.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.User
{
    public class UserBLL : IUserBLL
    {
        private readonly IUserDAL _userDAL;
        public UserBLL(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        public ResultModel<UserDto> GetAllUser()
        {
            return _userDAL.GetAllUser();
        }
    }
}
