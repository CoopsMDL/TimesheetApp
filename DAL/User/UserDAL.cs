using DataObjects.Context;
using DataObjects.DTO;
using System;
using System.Linq;

namespace DAL.User
{
    public class UserDAL : IUserDAL
    {
        #region Variables

        private readonly TimesheetDBContext _context;

        #endregion

        #region Constructor
        public UserDAL(TimesheetDBContext context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        public ResultModel<UserDto> GetAllUser()
        {
            ResultModel<UserDto> result = new ResultModel<UserDto>();
            try
            {
                result.DataList = _context.TimesheetUsers.Select(s => new UserDto
                {
                    Id = s.Id,
                    Email = s.Email,
                    FirstName = s.FirstName,
                    LastName = s.LastName
                }).ToList();
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Msg = ex.Message;
            }
            return result;
        }
        #endregion
    }
}
