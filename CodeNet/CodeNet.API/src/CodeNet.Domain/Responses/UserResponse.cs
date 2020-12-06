using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Responses
{
    public class UserResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public long IsActive { get; set; }
    }
}