using CodeNet.Domain.Entities;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers
{
    public class UserMapper : IUserMapper
    {
        public UserResponse Map(User source)
        {
            if (source == null)
                return null;
            return new UserResponse
            {
                Id = source.Id,
                Name = source.Name,
                UserName = source.UserName,
                IsActive = source.IsActive,
            };
        }

        public User Map(UserRequest source)
        {
            if (source == null)
                return null;
            return new User
            {
                Id = source.Id,
                Name = source.Name,
                UserName = source.UserName,
                IsActive = source.IsActive,
            };
        }
    }
}
