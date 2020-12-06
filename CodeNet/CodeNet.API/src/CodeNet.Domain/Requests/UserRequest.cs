using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Requests
{
    public class UserRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public long IsActive { get; set; }
    }
}