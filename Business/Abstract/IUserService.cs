using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Task<IEnumerable<UserDetailDto>> GetAll();
        Task<UserDto> Get(int id);
        Task<UserDto> Add(UserAddDto UserAddDto);
        Task<bool> Delete(int id);
        Task<UserUpdateDto> Update(UserUpdateDto UserUpdateDto);
    }
}
