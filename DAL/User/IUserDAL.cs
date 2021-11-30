
using DataObjects.DTO;

namespace DAL.User
{
    public interface IUserDAL
    {
        ResultModel<UserDto> GetAllUser();
    }
}
