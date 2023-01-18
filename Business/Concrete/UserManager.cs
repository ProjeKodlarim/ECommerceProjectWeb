using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }


        public async Task<UserDto> Add(UserAddDto userAddDto)
        {
            User user = new User()
            {
                Adress = userAddDto.Adress,
                Email = userAddDto.Email,
                FirstName = userAddDto.FirstName,
                Gender = userAddDto.Gender,
                LastName = userAddDto.LastName,
                Password = userAddDto.Password,
                UserName = userAddDto.UserName,
                DateOfBirtday = userAddDto.DateOfBirtday,
                CreatedDate = DateTime.Now,
                CreatedUserId = 1,
            };
            var userAdd = await _userDal.Add(user);

            UserDto userDto = new UserDto()
            {
                Adress = userAdd.Adress,
                Email = userAdd.Email,
                FirstName = userAdd.FirstName,
                Gender = userAdd.Gender,
                LastName = userAdd.LastName,
                UserName = userAdd.UserName,
                DateOfBirtday = userAdd.DateOfBirtday,
                Id= userAdd.Id 
            };
            return userDto;
        }

        public async Task<bool> Delete(int id)
        {
            return await _userDal.Delete(id);

        }

        public async Task<UserDto> Get(int id)
        {
            var user =await _userDal.Get(x=>x.Id==id);
            UserDto userDto = new UserDto()
            {
                Id = user.Id,
                Adress = user.Adress,
                DateOfBirtday = user.DateOfBirtday,
                Email = user.Email,
                FirstName =user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Gender = user.Gender
            };
            return userDto;
        }

        public async Task<IEnumerable<UserDetailDto>> GetAll()
        {
            List<UserDetailDto> userDetailDtos = new List<UserDetailDto>();
            var response = await _userDal.GetAll();
            foreach (var item in response.ToList())
            {
                userDetailDtos.Add(new UserDetailDto()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Gender = item.Gender == true ? "Erkek" : "Kadın",
                    DateOfBirtday = item.DateOfBirtday,
                    UserName = item.UserName,
                    Adress = item.Adress,
                    Email = item.Email,
                    Id = item.Id
                });
            }
            return userDetailDtos;
        }

        public async Task<UserUpdateDto> Update(UserUpdateDto UserUpdateDto)
        {
            var getUser = await _userDal.Get(x => x.Id == UserUpdateDto.Id);
            User user = new User()
            {
                FirstName= UserUpdateDto.FirstName,
                LastName= UserUpdateDto.LastName,
                Email= UserUpdateDto.Email,
                Gender= UserUpdateDto.Gender,
                Password= UserUpdateDto.Password,
                UserName= UserUpdateDto.UserName,
                Adress= UserUpdateDto.Adress,
                CreatedDate = getUser.CreatedDate,
                CreatedUserId =getUser.CreatedUserId,
                DateOfBirtday= UserUpdateDto.DateOfBirtday,
                Id=getUser.Id,
                UpdatedDate=DateTime.Now,
                UpdatedUserId=1
            };
            var userUpdate = await _userDal.Update(user);
            UserUpdateDto userUpdateDto = new UserUpdateDto()
            {
                FirstName = userUpdate.FirstName,
                LastName = userUpdate.LastName,
                Email = userUpdate.Email,
                Gender = userUpdate.Gender,
                Password = userUpdate.Password,
                UserName = userUpdate.UserName,
                Adress = userUpdate.Adress,
                DateOfBirtday = userUpdate.DateOfBirtday,
                Id = userUpdate.Id
            };

            return userUpdateDto;
        }
    }
}
