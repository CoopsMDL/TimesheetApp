using DataObjects.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.User
{
    public interface IUserBLL
    {
        ResultModel<UserDto> GetAllUser();
    }
}
