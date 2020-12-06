using CodeNet.Domain.Entities;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers.Interfaces
{
    public interface IUserMapper
    {
        UserResponse Map(User source);
        User Map(UserRequest source);
    }
}
